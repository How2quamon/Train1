using System.ComponentModel.DataAnnotations;

namespace Train1.Models
{
    public class KhachHangViewModel
    {
        public Guid MaKhachHang { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenKhachHang { get; set; }
        public int SDT { get; set; }
        [MaxLength(100)]
        public string DiaChi { get; set; }
    }
}
