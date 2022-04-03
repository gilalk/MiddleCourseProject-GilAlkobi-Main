namespace SchoolManagement.DB.Models
{
    public partial class Student
    {
        public Student()
        {
            HomeWorks = new HashSet<HomeWork>();
            StudentClasses = new HashSet<StudentClass>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? EmergacyContactName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual ICollection<HomeWork> HomeWorks { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
