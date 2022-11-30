using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Train1.Data
{
    [Table("Phong")]
    public class Phong
    {
        [Key]
        public Guid MaPhong { get; set; }
        [Required]
        [MaxLength(10)]
        public string TenPhong { get; set; }
        public int TongSoGhe { get; set; }
        public Guid MaRap { get; set; }
        [ForeignKey  ("MaRap")]
        public Rap Rap { get; set; }
    }
}
