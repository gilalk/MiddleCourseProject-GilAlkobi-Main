using System;
using System.Collections.Generic;

namespace ManagerForm.Models
{
    public partial class StudentParent
    {
        public int ParentId { get; set; }
        public int StudentId { get; set; }

        public virtual Parent Parent { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
