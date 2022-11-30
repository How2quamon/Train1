using Microsoft.EntityFrameworkCore;

namespace Train1.Data
{
    public class CTQM_DbContext : DbContext
    {
        public CTQM_DbContext(DbContextOptions<CTQM_DbContext> options) : base(options) { }

        public DbSet<Ghe>? Ghes { get; set; }
        public DbSet<KhachHang>? KhachHangs { get; set; }
        public DbSet<LichChieu>? LichChieus { get; set; }
        public DbSet<NhanVIen>? NhanVIens { get; set;}
        public DbSet<Phim>? Phims { get; set; }
        public DbSet<Phong>? Phongs { get; set; }
        public DbSet<Rap>? Raps { get; set; }
        public DbSet<ThongTinPhim>? ThongTinPhims { get; set; }
        public DbSet<Ve>? Ves { get; set; }
    }
}
