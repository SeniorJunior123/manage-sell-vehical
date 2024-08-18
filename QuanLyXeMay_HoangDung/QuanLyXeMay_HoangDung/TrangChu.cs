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
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using QuanLyXeMay_HoangDung.UserControl;
using System.Threading;

namespace QuanLyXeMay_HoangDung
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {
            if (e.Element == null) return;
            bool added = false;
            for (int i = 0; i < tabbedView.Documents.Count; i++)
            {
                if (tabbedView.Documents[i].Caption == e.Element.Text)
                {
                    tabbedView.ActivateDocument(tabbedView.Documents[i].Control);
                    added = true;
                    break;
                }
            }
            if (!added)
            {
                XtraUserControl userControl = null;
                switch (e.Element.Text)
                {
                    case "Danh sách nhân viên":
                        {
                            userControl = new DanhSachNhanVien();
                            break;
                        }
                    case "Danh sách khách hàng":
                        {
                            userControl = new DanhSachKhachHang();
                            break;
                        }
                    case "Danh sách xe":
                        {
                            userControl = new DanhSachXe();
                            break;
                        }
                    case "Nhà cung cấp":
                        {
                            userControl = new DanhSachNhaCungCap();
                            break;
                        }
                    case "Xuất hàng":
                        {
                            userControl = new BanHang();
                            break;
                        }
                    case "Nhập hàng":
                        {
                            userControl = new MuaHang();
                            break;
                        }
                    case "Báo cáo nhập":
                        {
                            LichSuNhapHang lichSuNhapHang = new LichSuNhapHang();
                            userControl = null;
                            lichSuNhapHang.ShowDialog();
                            break;
                        }
                    case "Báo cáo xuất":
                        {
                            LichSuBanHang lichSuBanHang = new LichSuBanHang();
                            userControl = null;
                            lichSuBanHang.ShowDialog();
                            break;
                        }
                    case "Tồn kho":
                        {
                            ThongKeTonKho thongKeTonKho = new ThongKeTonKho();
                            userControl = null;
                            thongKeTonKho.ShowDialog();
                            break;
                        }
                    default:
                        {
                            userControl = null;
                            break;
                        }
                }
                if (userControl != null)
                {
                    tabbedView.AddDocument(userControl).Caption = e.Element.Text;
                    tabbedView.ActivateDocument(userControl);
                }
            }
        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        }
        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if(Login.quyen != 1)
            {
                bbtQuanLyND.Enabled = false;
                bbtDSNV.Enabled = false;
                aceDSNV.Enabled = false;
            }
            bsiHello.Caption = "Xin chào: " + Login.fullname;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void bbtDSNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraUserControl userControl = new DanhSachNhanVien();
               AddNewTabMenu("Danh sách nhân viên", userControl);
        }

        //Thêm mới tab vào menu
        private void AddNewTabMenu(string v, XtraUserControl userControl)
        {
            bool added = false;
            for (int i = 0; i < tabbedView.Documents.Count; i++)
            {
                if (tabbedView.Documents[i].Caption == v)
                {
                    tabbedView.ActivateDocument(tabbedView.Documents[i].Control);
                    added = true;
                    break;
                }
            }
            if (!added)
            {
                tabbedView.AddDocument(userControl).Caption = v;
                tabbedView.ActivateDocument(userControl);
            }
        }

        private void bbtDSKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraUserControl userControl = new DanhSachKhachHang();
               AddNewTabMenu("Danh sách khách hàng", userControl);
        }

        private void bbtDSXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraUserControl userControl = new DanhSachXe();
               AddNewTabMenu("Danh sách xe", userControl);
        }

        private void bbtMauXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            CauHinhMauXe chMauXe = new CauHinhMauXe();
            chMauXe.ShowDialog();
        }

        private void bbtNhaCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraUserControl userControl = new DanhSachNhaCungCap();
            AddNewTabMenu("Nhà cung cấp", userControl);
        }

        private void bbtXuatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraUserControl userControl = new BanHang();
            AddNewTabMenu("Xuất hàng", userControl);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bsiTgian.Caption = "Bây giờ là: " + DateTime.Now.ToString("hh:mm:ss tt") + " ngày " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void bbtNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraUserControl nhapHang = new MuaHang();
            AddNewTabMenu("Nhập hàng", nhapHang);
        }

        private void bbtHangXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhSachHangXe danhSachHangXe = new DanhSachHangXe();
            danhSachHangXe.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            LichSuNhapHang lichSuNhapHang = new LichSuNhapHang();
            lichSuNhapHang.ShowDialog();
        }

        private void bbtBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            LichSuBanHang lichSuBanHang = new LichSuBanHang();
            lichSuBanHang.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbtDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void bbtQuanLyND_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhSachNguoiDung danhSachNguoiDung = new DanhSachNguoiDung();
            danhSachNguoiDung.ShowDialog();
        }
    }
}