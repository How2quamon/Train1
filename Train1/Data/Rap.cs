using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Train1.Data
{
    [Table("Rap")]
    public class Rap
    {
        [Key]
        public Guid MaRap { get; set; }
        [Required]
        [MaxLength(100)]
        public string ?TenRap { get; set; }
        public string ?DiaChi { get; set; }
        public string ?SDT { get; set; }
    }
}
