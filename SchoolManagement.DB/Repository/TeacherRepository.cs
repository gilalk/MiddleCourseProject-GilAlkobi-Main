using SchoolManagement.DB.Models;

namespace SchoolManagement.DB
{
    public class TeacherRepository : GenericRepository<CrewMember>, ICrewMemberRepository
    {

        /* 
        Most of methods here are same as manager for now,
        this class can be more usefull in future 
        when the program will be bigger.
        */

        public TeacherRepository(SchoolManagementContext context) : base(context)
        {
        }

        /// <summary>
        /// get a crew member to have lisy of classes (school classes)
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns> list of classes related to specific crew member </returns>
        public List<int> GetClassesByTeacher(CrewMember teacher)
        {
            var classes = _context.Classes.Where(c => c.CrewMemberId == teacher.Id).Select(cl => cl.ClassId).ToList();
            return classes;
        }

        #region Not Implemented Methods

        public CrewMember GetCrewMemberByFullName(string fullName)
        {
            throw new NotImplementedException();
        }

        public List<string> GetGeneralInfOnSpecificCrewMembers(string crewMemberFullName)
        {
            throw new NotImplementedException();
        }

        public List<string> GetGeneralInfoOnSpecificStudents(string studentFullName)
        {
            throw new NotImplementedException();
        }
        public List<string> GetStudentsNamesByClass(int classId)
        {
            throw new NotImplementedException();
        }

        #endregion

        /// <summary>
        /// getting student from database by class related to a specific teacher
        /// </summary>
        /// <param name="classId"></param>
        /// <returns>list of students related to this class</returns>
        public List<Student> GetStudentsByClass(int classId)
        {
            var studentsId = _context.StudentClasses.Where(st => st.ClassId == classId).Select(s => s).ToList();
            List<Student> students = new List<Student>();
            foreach (var student in studentsId)
            {
                var studentForList = _context.Students.Where(s => s.Id == student.StudentId).Select(s => s).FirstOrDefault();
                students.Add(studentForList);
            }
            return students;
        }


    }
}
