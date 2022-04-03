namespace SchoolManagement.DB.Models
{
    public partial class HomeWork
    {
        public int HwId { get; set; }
        public int? StudentId { get; set; }
        public DateTime? SignDate { get; set; }
        public byte[]? Hwcontent { get; set; }
        public int? ClassId { get; set; }
        public int? Grade { get; set; }

        public virtual Student? Student { get; set; }
    }
}
