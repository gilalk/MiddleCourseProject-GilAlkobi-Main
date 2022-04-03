using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManagment
{
    public class AdminProxy : IAdmin, ITeacher
    {
        
        public void AddGrade()
        {
            throw new NotImplementedException();
        }

        public void ChangeGrade()
        {
            throw new NotImplementedException();
        }
    }

    public class TeacherProxy : ITeacher
    {
        public void AddGrade()
        {
            throw new NotImplementedException();
        }

        public void ChangeGrade()
        {
            throw new NotImplementedException();
        }
    }

}
