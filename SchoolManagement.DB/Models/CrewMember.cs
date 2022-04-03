namespace SchoolManagement.DB.Models
{
    public partial class CrewMember
    {
        public CrewMember()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string? Role { get; set; }
        public string? Subject { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Adress { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual ICollection<Class> Classes { get; set; }
    }
}
