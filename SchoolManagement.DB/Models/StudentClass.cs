namespace SchoolManagement.DB.Models
{
    public partial class StudentClass
    {
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public int Id { get; set; }

        public virtual Class Class { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
