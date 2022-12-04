using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
namespace Train1.Data
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public Guid MaKhachHang { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenKhachHang { get; set; }
        public int SDT { get; set; }
        [MaxLength(100)]
        public string DiaChi { get; set; }
    }
}
