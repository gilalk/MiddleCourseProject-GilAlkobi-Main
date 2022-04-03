using System;
using System.Collections.Generic;

namespace ManagerForm.Models
{
    public partial class Account
    {
        public Account()
        {
            CrewMembers = new HashSet<CrewMember>();
            Parents = new HashSet<Parent>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<CrewMember> CrewMembers { get; set; }
        public virtual ICollection<Parent> Parents { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
