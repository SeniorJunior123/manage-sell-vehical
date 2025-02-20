﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyXeMay_HoangDung
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLXMEntities : DbContext
    {
        public QLXMEntities()
            : base("name=QLXMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual DbSet<ChiTietXe> ChiTietXes { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<MauXe> MauXes { get; set; }
        public virtual DbSet<HangXe> HangXes { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }
        public virtual DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public virtual DbSet<viewLichSuNhap> viewLichSuNhaps { get; set; }
        public virtual DbSet<viewLichSuXuat> viewLichSuXuats { get; set; }
    
        public virtual ObjectResult<timKiemLichSuNhapHang_Result> timKiemLichSuNhapHang(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<timKiemLichSuNhapHang_Result>("timKiemLichSuNhapHang", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<timKiemLichSuBanHang_Result> timKiemLichSuBanHang(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<timKiemLichSuBanHang_Result>("timKiemLichSuBanHang", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<timkiemTonKho_Result> timkiemTonKho(string hangXe, string loaiXe, string phanKhoi, string tenXe)
        {
            var hangXeParameter = hangXe != null ?
                new ObjectParameter("hangXe", hangXe) :
                new ObjectParameter("hangXe", typeof(string));
    
            var loaiXeParameter = loaiXe != null ?
                new ObjectParameter("loaiXe", loaiXe) :
                new ObjectParameter("loaiXe", typeof(string));
    
            var phanKhoiParameter = phanKhoi != null ?
                new ObjectParameter("phanKhoi", phanKhoi) :
                new ObjectParameter("phanKhoi", typeof(string));
    
            var tenXeParameter = tenXe != null ?
                new ObjectParameter("tenXe", tenXe) :
                new ObjectParameter("tenXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<timkiemTonKho_Result>("timkiemTonKho", hangXeParameter, loaiXeParameter, phanKhoiParameter, tenXeParameter);
        }
    }
}
