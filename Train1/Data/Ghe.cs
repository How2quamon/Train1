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
        [Foreignkey("MaPhong")]
        public Phong Phong { get; set; }
    }
}
