using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Train1.Data
{
    [Table("Ve")]
    public class Ve
    {
        [Key]
        public Guid MaVe { get; set; }
        [Required]
        public double GiaVe { get; set; }
        public Guid MaGhe { get; set; }
        [ForeignKey("MaGhe")]
        public Ghe? Ghe { get; set; }
        public Guid MaKhachHang { get; set; }
        [ForeignKey("MaKhachHang")]
        public KhachHang? KhachHang { get; set; }
        public Guid MaNhanVien { get; set; }
        [ForeignKey("MaNhanVien")]
        public NhanVIen? NhanVien { get; set; }

    }
}
