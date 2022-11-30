namespace Train1.Data
{
    [Table("LichChieu")]
    public class LichChieu
    {
        [Key]
        public Guid MaLichChieu { get; set; }
        public date NgayChieu { get; set; }
        public date GioChieu { get; set; }
        public float SoVeDaDat {get; set;}

        public float TongTien { get; set; }
        public Guid MaPhim  { get; set; }
        [Foreignkey("MaPhim")]
        public Phim Phim { get; set; }

        public Guid MaPhong { get; set; }
        [Foreignkey("MaPhong")]
        public Phong Phong { get; set; }
    }
}
