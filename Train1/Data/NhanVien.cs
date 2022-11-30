namespace Train1.Data
{
    [table("NhanVien")]
    public class NhanVIen
    {
        [Key]
        public Guid MaNhanVien { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenNhanVien { get; set; }
        [MaxLength(100)]
        public string DiaChi { get; set; }
        public int SDT { get; set; }
        public int Ca { get; set; }
    }
}
