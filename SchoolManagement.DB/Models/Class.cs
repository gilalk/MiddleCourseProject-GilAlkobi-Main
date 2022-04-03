namespace SchoolManagement.DB.Models
{
    public partial class Class
    {
        public Class()
        {
            StudentClasses = new HashSet<StudentClass>();
        }

        public int ClassId { get; set; }
        public string? SubjectName { get; set; }
        public int? CrewMemberId { get; set; }
        public int? ClassCode { get; set; }
        public string? ClassName { get; set; }

        public virtual CrewMember? CrewMember { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
