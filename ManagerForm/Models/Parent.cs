using System;
using System.Collections.Generic;

namespace ManagerForm.Models
{
    public partial class Parent
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? WorkAddress { get; set; }
        public int? AccountId { get; set; }

        public virtual Account? Account { get; set; }
    }
}
