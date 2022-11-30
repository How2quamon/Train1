using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Train1.Data
{
    [Table("Phim")]
    public class Phim
    {
        [Key]
        public Guid MaPhim { get; set; }
        [Required]
        [MaxLength(100)]
        public string ?TenPhim { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public DateTime NgayKetThuc { get; set; }

    }
}
