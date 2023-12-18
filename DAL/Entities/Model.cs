using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CT_BaoHanh> CT_BaoHanh { get; set; }
        public virtual DbSet<CT_KMai> CT_KMai { get; set; }
        public virtual DbSet<CT_MauXe> CT_MauXe { get; set; }
        public virtual DbSet<CT_PNhapPTVL> CT_PNhapPTVL { get; set; }
        public virtual DbSet<CT_PNhapXe> CT_PNhapXe { get; set; }
        public virtual DbSet<CT_PPXE> CT_PPXE { get; set; }
        public virtual DbSet<CT_PXPTVL> CT_PXPTVL { get; set; }
        public virtual DbSet<HangSX> HangSXes { get; set; }
        public virtual DbSet<HopDongDichVu> HopDongDichVus { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<MapKhoChua> MapKhoChuas { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<MauXe> MauXes { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuBaoHanh> PhieuBaoHanhs { get; set; }
        public virtual DbSet<PhieuDoiTra> PhieuDoiTras { get; set; }
        public virtual DbSet<PhieuGiaoHang> PhieuGiaoHangs { get; set; }
        public virtual DbSet<PhieuHen> PhieuHens { get; set; }
        public virtual DbSet<PhieuNhapHang> PhieuNhapHangs { get; set; }
        public virtual DbSet<PhieuThanhToan> PhieuThanhToans { get; set; }
        public virtual DbSet<PhieuXuatPTVL> PhieuXuatPTVLs { get; set; }
        public virtual DbSet<PhieuXuatXe> PhieuXuatXes { get; set; }
        public virtual DbSet<PhuTung_VatLieu> PhuTung_VatLieu { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoanLogin> TaiKhoanLogins { get; set; }
        public virtual DbSet<CT_GiaoHang> CT_GiaoHang { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_BaoHanh>()
                .Property(e => e.ID_BAOHANH)
                .IsFixedLength();

            modelBuilder.Entity<CT_BaoHanh>()
                .Property(e => e.IDHD)
                .IsFixedLength();

            modelBuilder.Entity<CT_KMai>()
                .Property(e => e.ID_TIEUCHI)
                .IsFixedLength();

            modelBuilder.Entity<CT_KMai>()
                .Property(e => e.IDKM)
                .IsFixedLength();

            modelBuilder.Entity<CT_KMai>()
                .Property(e => e.IDHSX)
                .IsFixedLength();

            modelBuilder.Entity<CT_KMai>()
                .Property(e => e.IDMAUXE)
                .IsFixedLength();

            modelBuilder.Entity<CT_KMai>()
                .Property(e => e.IDHANG)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.SOKHUNG)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.SOMAY)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.IDMAUXE)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.ID_NHAPHANG)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.IDMAU)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.IDVITRI)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .HasMany(e => e.CT_GiaoHang)
                .WithRequired(e => e.CT_MauXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_PNhapPTVL>()
                .Property(e => e.IDHANG)
                .IsFixedLength();

            modelBuilder.Entity<CT_PNhapPTVL>()
                .Property(e => e.ID_NHAPHANG)
                .IsFixedLength();

            modelBuilder.Entity<CT_PNhapPTVL>()
                .Property(e => e.TONGGT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CT_PNhapXe>()
                .Property(e => e.IDMAUXE)
                .IsFixedLength();

            modelBuilder.Entity<CT_PNhapXe>()
                .Property(e => e.ID_NHAPHANG)
                .IsFixedLength();

            modelBuilder.Entity<CT_PNhapXe>()
                .Property(e => e.TONGGT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CT_PPXE>()
                .Property(e => e.IDPX_XE)
                .IsFixedLength();

            modelBuilder.Entity<CT_PPXE>()
                .Property(e => e.IDMAUXE)
                .IsFixedLength();

            modelBuilder.Entity<CT_PXPTVL>()
                .Property(e => e.IDHANG)
                .IsFixedLength();

            modelBuilder.Entity<CT_PXPTVL>()
                .Property(e => e.IDPX_PTVL)
                .IsFixedLength();

            modelBuilder.Entity<HangSX>()
                .Property(e => e.IDHANGSX)
                .IsFixedLength();

            modelBuilder.Entity<HangSX>()
                .HasMany(e => e.CT_KMai)
                .WithOptional(e => e.HangSX)
                .HasForeignKey(e => e.IDHSX);

            modelBuilder.Entity<HangSX>()
                .HasMany(e => e.MauXes)
                .WithRequired(e => e.HangSX)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangSX>()
                .HasMany(e => e.PhuTung_VatLieu)
                .WithRequired(e => e.HangSX)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HopDongDichVu>()
                .Property(e => e.IDHD)
                .IsFixedLength();

            modelBuilder.Entity<HopDongDichVu>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<HopDongDichVu>()
                .Property(e => e.IDKH)
                .IsFixedLength();

            modelBuilder.Entity<HopDongDichVu>()
                .Property(e => e.TONGGT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HopDongDichVu>()
                .HasMany(e => e.CT_BaoHanh)
                .WithRequired(e => e.HopDongDichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HopDongDichVu>()
                .HasMany(e => e.PhieuGiaoHangs)
                .WithRequired(e => e.HopDongDichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HopDongDichVu>()
                .HasMany(e => e.PhieuHens)
                .WithRequired(e => e.HopDongDichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HopDongDichVu>()
                .HasMany(e => e.PhieuXuatPTVLs)
                .WithRequired(e => e.HopDongDichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HopDongDichVu>()
                .HasMany(e => e.PhieuXuatXes)
                .WithRequired(e => e.HopDongDichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.IDKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.IDCCCD)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.EMAIL)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HopDongDichVus)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuDoiTras)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.IDKM)
                .IsFixedLength();

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.ACTIVE)
                .IsFixedLength();

            modelBuilder.Entity<KhuyenMai>()
                .HasMany(e => e.CT_KMai)
                .WithRequired(e => e.KhuyenMai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhuyenMai>()
                .HasMany(e => e.PhieuThanhToans)
                .WithRequired(e => e.KhuyenMai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapKhoChua>()
                .Property(e => e.IDVITRI)
                .IsFixedLength();

            modelBuilder.Entity<MauSac>()
                .Property(e => e.IDMAU)
                .IsFixedLength();

            modelBuilder.Entity<MauSac>()
                .HasMany(e => e.CT_MauXe)
                .WithRequired(e => e.MauSac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MauXe>()
                .Property(e => e.IDMAUXE)
                .IsFixedLength();

            modelBuilder.Entity<MauXe>()
                .Property(e => e.GIANHAP)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MauXe>()
                .Property(e => e.GIABAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MauXe>()
                .Property(e => e.IDNCC)
                .IsFixedLength();

            modelBuilder.Entity<MauXe>()
                .Property(e => e.IDHANGSX)
                .IsFixedLength();

            modelBuilder.Entity<MauXe>()
                .HasMany(e => e.CT_PNhapXe)
                .WithRequired(e => e.MauXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MauXe>()
                .HasMany(e => e.CT_PPXE)
                .WithRequired(e => e.MauXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.IDNCC)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.MauXes)
                .WithRequired(e => e.NhaCungCap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.NAMSINH)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.EMAIL)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.IDCCCD)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.NGAYGN)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HopDongDichVus)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuBaoHanhs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuDoiTras)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuGiaoHangs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuHens)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuNhapHangs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuBaoHanh>()
                .Property(e => e.ID_BAOHANH)
                .IsFixedLength();

            modelBuilder.Entity<PhieuBaoHanh>()
                .Property(e => e.IDHD)
                .IsFixedLength();

            modelBuilder.Entity<PhieuBaoHanh>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<PhieuBaoHanh>()
                .HasMany(e => e.CT_BaoHanh)
                .WithRequired(e => e.PhieuBaoHanh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuDoiTra>()
                .Property(e => e.ID_DOITRA)
                .IsFixedLength();

            modelBuilder.Entity<PhieuDoiTra>()
                .Property(e => e.IDKH)
                .IsFixedLength();

            modelBuilder.Entity<PhieuDoiTra>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<PhieuGiaoHang>()
                .Property(e => e.ID_GIAOHANG)
                .IsFixedLength();

            modelBuilder.Entity<PhieuGiaoHang>()
                .Property(e => e.IDHD)
                .IsFixedLength();

            modelBuilder.Entity<PhieuGiaoHang>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<PhieuGiaoHang>()
                .HasMany(e => e.CT_GiaoHang)
                .WithRequired(e => e.PhieuGiaoHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuHen>()
                .Property(e => e.ID_HEN)
                .IsFixedLength();

            modelBuilder.Entity<PhieuHen>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<PhieuHen>()
                .Property(e => e.IDHD)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.ID_NHAPHANG)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.IDNCC)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.TONGHOADON)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhieuNhapHang>()
                .HasMany(e => e.CT_MauXe)
                .WithRequired(e => e.PhieuNhapHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhapHang>()
                .HasMany(e => e.CT_PNhapPTVL)
                .WithRequired(e => e.PhieuNhapHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhapHang>()
                .HasMany(e => e.CT_PNhapXe)
                .WithRequired(e => e.PhieuNhapHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuThanhToan>()
                .Property(e => e.ID_THANHTOAN)
                .IsFixedLength();

            modelBuilder.Entity<PhieuThanhToan>()
                .Property(e => e.IDKM)
                .IsFixedLength();

            modelBuilder.Entity<PhieuThanhToan>()
                .Property(e => e.TONGGT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhieuThanhToan>()
                .Property(e => e.IDHD)
                .IsFixedLength();

            modelBuilder.Entity<PhieuThanhToan>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<PhieuXuatPTVL>()
                .Property(e => e.IDPX_PTVL)
                .IsFixedLength();

            modelBuilder.Entity<PhieuXuatPTVL>()
                .Property(e => e.IDHD)
                .IsFixedLength();

            modelBuilder.Entity<PhieuXuatPTVL>()
                .HasMany(e => e.CT_PXPTVL)
                .WithRequired(e => e.PhieuXuatPTVL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuXuatXe>()
                .Property(e => e.IDPX_XE)
                .IsFixedLength();

            modelBuilder.Entity<PhieuXuatXe>()
                .Property(e => e.IDHD)
                .IsFixedLength();

            modelBuilder.Entity<PhieuXuatXe>()
                .HasMany(e => e.CT_PPXE)
                .WithRequired(e => e.PhieuXuatXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhuTung_VatLieu>()
                .Property(e => e.IDHANG)
                .IsFixedLength();

            modelBuilder.Entity<PhuTung_VatLieu>()
                .Property(e => e.GIANHAP)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhuTung_VatLieu>()
                .Property(e => e.GIABAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhuTung_VatLieu>()
                .Property(e => e.IDNCC)
                .IsFixedLength();

            modelBuilder.Entity<PhuTung_VatLieu>()
                .Property(e => e.IDHANGSX)
                .IsFixedLength();

            modelBuilder.Entity<PhuTung_VatLieu>()
                .HasMany(e => e.CT_PNhapPTVL)
                .WithRequired(e => e.PhuTung_VatLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhuTung_VatLieu>()
                .HasMany(e => e.CT_PXPTVL)
                .WithRequired(e => e.PhuTung_VatLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoanLogin>()
                .Property(e => e.MATKHAU)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoanLogin>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.TaiKhoanLogin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_GiaoHang>()
                .Property(e => e.ID_GIAOHANG)
                .IsFixedLength();

            modelBuilder.Entity<CT_GiaoHang>()
                .Property(e => e.SOKHUNG)
                .IsFixedLength();
        }
    }
}
