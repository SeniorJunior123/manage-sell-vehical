using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay_HoangDung.Class
{
    public class HoaDon
    {
        private static QLXMEntities db = new QLXMEntities();
        public HoaDon()
        {

        }

        /// <summary>
        /// Tạo số hóa đơn bán hàng
        /// </summary>
        /// <returns>Số hóa đơn bán hàng</returns>
        public static string SoHoaDonBanHang()
        {
            string soHD = "";
            var dem = db.PhieuXuats.Select(s => s).Count();
            if (dem == 0)//Nếu chưa có hóa đơn nào thì coi như số háo đơn là 1
            {
                soHD = "1";
            }
            else
            {
                //Nếu đã có thì lấy ra số hóa đơn cuối cùng rồi cộng thêm 1
                string lastHD = db.PhieuXuats.Select(s => s).OrderByDescending(s => s.MaPX).FirstOrDefault().MaPX;
                int soHDcuoi = int.Parse(lastHD.Replace("HDBH", ""));
                soHD = (soHDcuoi + 1) + "";
            }
            while (soHD.Length < 10)
            {
                soHD = "0" + soHD;
            }
            soHD = "HDBH" + soHD;
            return soHD;
        }

        /// <summary>
        /// Tạo số hóa đơn nhập hàng
        /// </summary>
        /// <returns>Số hóa đơn nhập hàng</returns>
        public static string SoHoaDonMuaHang()
        {
            string soHD = "";
            var dem = db.PhieuNhaps.Select(s => s).Count();
            if (dem == 0)//Nếu chưa có hóa đơn nào thì coi như số háo đơn là 1
            {
                soHD = "1";
            }
            else
            {
                //Nếu đã có thì lấy ra số hóa đơn cuối cùng rồi cộng thêm 1
                string lastHD = db.PhieuNhaps.Select(s => s).OrderByDescending(s => s.MaPN).FirstOrDefault().MaPN;
                int soHDcuoi = int.Parse(lastHD.Replace("HDMH", ""));
                soHD = (soHDcuoi + 1) + "";
            }
            while (soHD.Length < 10)
            {
                soHD = "0" + soHD;
            }
            soHD = "HDMH" + soHD;
            return soHD;
        }
    }
}
