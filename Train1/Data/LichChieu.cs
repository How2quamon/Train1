using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Train1.Data
{
    [Table("LichChieu")]
    public class LichChieu
    {
        [Key]
        public Guid MaLichChieu { get; set; }
        public DateTime NgayChieu { get; set; }
        public DateTime GioChieu { get; set; }
        public float SoVeDaDat {get; set;}

        public float TongTien { get; set; }
        public Guid MaPhim  { get; set; }
        [ForeignKey("MaPhim")]
        public Phim Phim { get; set; }

        public Guid MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public Phong Phong { get; set; }
    }
}
