using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
namespace Train1.Data
{
    [Table("Ghe")]
    public class Ghe
    {
        
        [Key]
        public Guid MaGhe { get; set; } 
      
        [Required]
        [MaxLength(100)]
        public string TenGhe { get; set; }
        [MaxLength(100)]
        public bool TrangThai { get; set; }

        public Guid MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public Phong Phong { get; set; }
    }
}
