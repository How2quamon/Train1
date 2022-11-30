using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Train1.Data
{
    [Table("ThongTinPhim")]
    public class ThongTinPhim
    {
        [Key]
        public Guid MaPhim { get; set; }
        public string ?TenNXS { get; set; }
        public string ?HXS { get; set; }
        [Required]
        public string ?DaoDien { get; set; }
        public string ?TheLoai { get; set; }
    }
}
