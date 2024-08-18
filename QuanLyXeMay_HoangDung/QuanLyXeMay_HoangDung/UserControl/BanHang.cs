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
using QuanLyXeMay_HoangDung.Class;
using ClosedXML.Excel;
using System.Diagnostics;

namespace QuanLyXeMay_HoangDung.UserControl
{
    public partial class BanHang : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLXMEntities db = new QLXMEntities();
        private static string imagePath = Application.StartupPath + @"\AnhXe\";
        private static DataTable tbl;
        private double tongTien = 0;

        public BanHang()
        {
            InitializeComponent();
        }

        private void xeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            anhXePictureBox.ImageLocation = imagePath + xeDataGridView.CurrentRow.Cells[0].Value + ".jpg";
        }

        private void LoadDSSoKhung(string maxe)
        {
            var dssk = (from n in db.ChiTietXes
                        where n.MaXe == maxe && n.Active == true
                        select n).ToList();
            ChiTietXe chiTiet = new ChiTietXe();
            chiTiet.MaCT = 0;
            chiTiet.SoKhung = "-Chọn số khung-";
            dssk.Insert(0, chiTiet);
            cbbSoKhung.DataSource = dssk;
            cbbSoKhung.DisplayMember = "SoKhung";
            cbbSoKhung.ValueMember = "MaCT";
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            cbbLoaiXe.SelectedIndex = 0;
            LoadMauXe();
            LoadHangXe();
            btnAddGioHang.Enabled = false;
            TimKiemKH();
            txtTenKH.Focus();
            CreateTableDetailAvoid();
        }

        private void CreateTableDetailAvoid()
        {
            tbl = new DataTable();
            tbl.Columns.Add("TenXe");
            tbl.Columns.Add("MauXe");
            tbl.Columns.Add("SoKhung");
            tbl.Columns.Add("SoMay");
            tbl.Columns.Add("DonGia");
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

        private void LoadDSXe()
        {
            var dsxe = db.Xes.Select(s => s).ToList();
            xeBindingSource.DataSource = dsxe;
        }

        private void cbbHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {

            TimKiemXe();
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
            if(cbbLoaiXe.SelectedIndex != 0)
            {
                loai = cbbLoaiXe.Text;
            }
            else
            {
                loai = "";
            }
            if(cbbMauXe.SelectedIndex != 0)
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

        private void cbbMauXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemXe();
        }

        private void cbbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemXe();
        }

        private void txtTenXe_TextChanged(object sender, EventArgs e)
        {
            TimKiemXe();
        }

        private void btnChonXe_Click(object sender, EventArgs e)
        {
            LoadDSSoKhung(xeDataGridView.CurrentRow.Cells[0].Value.ToString());
            XtraMessageBox.Show("Chọn số khung để tiếp tục", "Hóa đơn bán hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbbSoKhung_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddGioHang.Enabled = true;
        }

        private void txtMaXe_TextChanged(object sender, EventArgs e)
        {
            TimKiemXe();
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            ThemMoiKH themMoiKH = new ThemMoiKH();
            themMoiKH.ShowDialog();
            TimKiemKH();
        }

        private void TimKiemKH()
        {
            var khach = (from n in db.KhachHangs
                         where n.TenKH.Contains(txtTenKH.Text)
                         select n).ToList();
            khachHangBindingSource.DataSource = khach;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            TimKiemKH();
        }

        private void btnChonKhach_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            txtMaXe.Focus();
            lbTenKH.Text = khachHangDataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAddGioHang_Click(object sender, EventArgs e)
        {
            if (cbbSoKhung.SelectedIndex != 0)
            {
                DataRow[] result = tbl.Select("SoKhung='" + cbbSoKhung.Text + "'");
                if (result.Count() > 0)
                {
                    XtraMessageBox.Show("Xe này đã được chọn trước đó");
                }
                else
                {
                    string maX = xeDataGridView.CurrentRow.Cells[0].Value.ToString();
                    if (lbMaHD.Text == "")
                    {
                        lbMaHD.Text = HoaDon.SoHoaDonBanHang();
                    }
                    DataRow row = tbl.NewRow();
                    row[0] = xeDataGridView.CurrentRow.Cells[1].Value;
                    row[1] = xeDataGridView.CurrentRow.Cells[2].Value;
                    row[2] = cbbSoKhung.Text;
                    row[3] = db.ChiTietXes.Select(s => s).Where(s => s.SoKhung.Equals(cbbSoKhung.Text)).FirstOrDefault().SoMay;
                    row[4] = db.Xes.Select(s => s).Where(s => s.MaXe.Equals(maX)).FirstOrDefault().DonGia;
                    tbl.Rows.Add(row);
                    gvChiTietHD.DataSource = tbl;
                    gvChiTietHD.Refresh();
                    tinhTongTien();
                    btnThanhToan.Enabled = true;
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn số khung");
            }
        }

        private void tinhTongTien()
        {
            tongTien = 0;
            for (int i = 0; i < gvChiTietHD.RowCount; i++)
            {
                tongTien = tongTien + double.Parse(gvChiTietHD.Rows[i].Cells[5].Value.ToString());
            }
            lbThanhTien.Text = tongTien.ToString("#,##0") + " VND";
        }

        private void gvChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == gvChiTietHD.Columns["Xoa"].Index)
            {
                try
                {
                    tbl.Rows.RemoveAt(e.RowIndex);
                    gvChiTietHD.DataSource = tbl;
                    gvChiTietHD.Refresh();
                    XtraMessageBox.Show("Đã xóa khỏi hóa đơn");
                    tinhTongTien();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Xóa không thành công!" + ex.Message);
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                //Thêm mới hóa đơn
                PhieuXuat hoadon = new PhieuXuat();
                hoadon.MaPX = lbMaHD.Text;
                hoadon.MaKH = int.Parse(khachHangDataGridView.CurrentRow.Cells[3].Value.ToString());
                hoadon.MaNV = "NV0001";
                hoadon.NgayXuat = DateTime.Now;
                hoadon.TongTien = tongTien;
                db.PhieuXuats.Add(hoadon);
                db.SaveChanges();
                //Thêm mới chi tiết hóa đơn
                for (int i = 0; i < gvChiTietHD.RowCount; i++)
                {
                    string maXe = xeDataGridView.Rows[i].Cells[0].Value.ToString();
                    string soKhung = gvChiTietHD.Rows[i].Cells[3].Value.ToString();
                    ChiTietPhieuXuat chiTietPhieuXuat = new ChiTietPhieuXuat();
                    chiTietPhieuXuat.MaPX = lbMaHD.Text;
                    chiTietPhieuXuat.MaXe = maXe;
                    chiTietPhieuXuat.SoKhung = soKhung;
                    chiTietPhieuXuat.SoMay = gvChiTietHD.Rows[i].Cells[4].Value.ToString();
                    chiTietPhieuXuat.DonGia = double.Parse(gvChiTietHD.Rows[i].Cells[5].Value.ToString());
                    db.ChiTietPhieuXuats.Add(chiTietPhieuXuat);
                    db.SaveChanges();
                    //Sửa lại trạng thái cho chi tiết xe sang đã mua
                    var chiTietXe = db.ChiTietXes.Select(s => s).Where(s => s.SoKhung.Equals(soKhung)).FirstOrDefault();
                    chiTietXe.Active = false;
                    chiTietXe.MaPX = lbMaHD.Text;
                    db.SaveChanges();
                    //Cập nhật lại số lượng xe
                    var xe = db.Xes.Select(s => s).Where(s => s.MaXe.Equals(maXe)).FirstOrDefault();
                    xe.SoLuong += -1;
                    db.SaveChanges();
                }
                XtraMessageBox.Show("Thanh toán thành công!", "Hóa đơn thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InHoaDon(tbl);
                txtMaXe.Text = "";
                txtTenKH.Text = "";
                txtTenXe.Text = "";
                lbMaHD.Text = "";
                lbTenKH.Text = "";
                tbl.Rows.Clear();
                cbbHangXe.SelectedIndex = 0;
                cbbLoaiXe.SelectedIndex = 0;
                cbbMauXe.SelectedIndex = 0;
                cbbSoKhung.SelectedIndex = 0;
                btnThanhToan.Enabled = false;
                panel3.Enabled = false;
                lbThanhTien.Text = "0 VND";
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Thanh toán thất bại!" + ex.Message, "Hóa đơn thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InHoaDon(DataTable dt)
        {
            string path = Application.StartupPath + @"\HoaDon\HoaDonBanHang.xlsx";
            XLWorkbook wb = new XLWorkbook(path);
            IXLWorksheet ws = wb.Worksheet(1);
            ws.Cell(9, 3).Value = lbTenKH.Text;
            int row = 12;
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        ws.Cell(i + row, 1).Value = i + 1;
                        ws.Cell(i + row, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        ws.Cell(i + row, 2).Value = dt.Rows[i]["TenXe"].ToString();
                        ws.Cell(i + row, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        ws.Cell(i + row, 3).Value = dt.Rows[i]["MauXe"].ToString();
                        ws.Cell(i + row, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        ws.Cell(i + row, 4).Value = "'" + dt.Rows[i]["SoKhung"].ToString();
                        ws.Cell(i + row, 4).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        ws.Cell(i + row, 5).Value = "'" + dt.Rows[i]["SoMay"].ToString();
                        ws.Cell(i + row, 5).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        ws.Cell(i + row, 6).Value = dt.Rows[i]["DonGia"].ToString();
                        ws.Cell(i + row, 6).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ws.Cell(dt.Rows.Count + row + 1, 5).Value = "Thành tiền";
                ws.Cell(dt.Rows.Count + row + 1, 5).Style.Font.Bold = true;

                ws.Cell(dt.Rows.Count + row + 1, 6).Value = double.Parse(lbThanhTien.Text.Replace(" VND", "").Replace(",", ""));
                ws.Cell(dt.Rows.Count + row + 1, 6).Style.Font.Bold = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel |*.xlsx";
            saveFileDialog.FileName = "HoaDonBanHang" + "_" + DateTime.Now.ToString("ddMMyyyy") + "_" + lbTenKH.Text;
            saveFileDialog.ShowDialog();
            string savePath = saveFileDialog.FileName;
            wb.SaveAs(savePath);
            Process.Start(savePath);
        }
    }
}
