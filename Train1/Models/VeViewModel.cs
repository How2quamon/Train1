using System.ComponentModel.DataAnnotations;

namespace Train1.Models
{
    public class VeViewModel
    {
        [Required]
        public Guid MaVe { get; set; }
        [Required]
        public Guid MaGhe { get; set; }
        [Required]
        public Guid MaKhachHang { get; set; }
        [Required]
        public Guid MaNhanVien { get; set; }
        [Required]
        public double GiaVe { get; set; }
    }
}
