using SchoolManagement.DB.Models;

namespace SchoolManagement.DB
{
    public class ManagerRepository : GenericRepository<CrewMember>, IManagerRepository
    {
        public ManagerRepository(SchoolManagementContext context) : base(context)
        {
        }

        /*
         * I seperated the functions to sectors for the order
         */

        #region CrewMembers

        /*
         * all functions here related to working with students
        */

        // returns list of teachers name for filling conmbobox in student control
        public List<string> GetTeachersNames()
        {
            var teachersNames = _context.CrewMembers.Where(t => t.Role == "teacher").Select(t => t.FirstName + " " + t.LastName).ToList();
            return teachersNames;
        }


        // return specific crew member by full name in combobox
        public CrewMember GetCrewMemberByFullName(string fullName)
        {
            var teacher = _context.CrewMembers.Where(t => t.FirstName + " " + t.LastName == fullName).Select(t => t).FirstOrDefault();
            return teacher;
        }

        // returns chosen crew member's general information
        public List<string> GetGeneralInfOnSpecificCrewMembers(string crewMemberFullName)
        {
            try
            {
                List<string> crewMembersGeneralInformation = new List<string>();
                var member = _context.CrewMembers.Where(cm => cm.FirstName + " " + cm.LastName == crewMemberFullName)
                    .Select(cm => new CrewMemberGeneralInfo()
                    {
                        firstName = cm.FirstName,
                        lastName = cm.LastName,
                        role = cm.Role,
                        subject = cm.Subject
                    }).ToList();
                crewMembersGeneralInformation.Add(member[0].firstName.ToString());
                crewMembersGeneralInformation.Add(member[0].lastName.ToString());
                crewMembersGeneralInformation.Add(member[0].role.ToString());
                crewMembersGeneralInformation.Add(member[0].subject);

                return crewMembersGeneralInformation;
            }
            catch (Exception)
            {
                throw new FormatException();
                throw;
            }
        }

        // returns all crew members except for manager names for combobox
        public List<string> GetAllCrewMembersNames()
        {
            var crewMembers = _context.CrewMembers.Where(cm => cm.Role != "manager").Select(cm => cm.FirstName + " " + cm.LastName).ToList();
            return crewMembers;
        }

        // returns all crewmembers in table
        public List<CrewMember> GetAllCrewMembers()
        {
            var AllInfoMemers = _context.CrewMembers.Select(cm => cm).ToList();
            return AllInfoMemers;
        }

        // adding new member
        public void AddCrewMember(CrewMember member)
        {
            _context.Set<CrewMember>().Add(member);
        }


        // create new account for new member - must have one-to-one connection
        public Account CreateCrewMemberAccount(CrewMember member)
        {
            Account userAccount = new Account();
            userAccount.UserName = member.FirstName.ToLower() + member.LastName.ToLower();
            userAccount.Password = member.FirstName.ToLower() + member.LastName.ToLower() + "123";
            var userExist = _context.Accounts.Where(u => u.UserName == userAccount.UserName).Any();
            while (userExist)
            {
                userAccount.UserName += "1";
            }

            _context.Set<Account>().Add(userAccount);
            _context.SaveChanges();
            return userAccount;
        }

        #endregion


        #region Students

        /*
         * all functions here related to working with students
         */

        // return names of students related to a specific class chosen in combobox
        public List<string> GetStudentsNamesByClass(int classId)
        {
            List<string> students = new List<string>();
            var studentList = _context.StudentClasses.Where(sc => sc.ClassId == classId).Select(sc => sc.Student).ToList();
            foreach (var student in studentList)
            {
                students.Add(student.FirstName + " " + student.LastName);
            }
            return students;
        }

        // returns chosen student's general information
        public List<string> GetGeneralInfoOnSpecificStudents(string studentFullName)
        {
            try
            {
                List<string> studentGeneralInformation = new List<string>();
                var student = _context.Students.Where(s => s.FirstName + " " + s.LastName == studentFullName)
                    .Select(s => new StudentGeneralInfo()
                    {
                        firstName = s.FirstName,
                        lastName = s.LastName,
                        DOB = s.DateOfBirth,
                        phoneNumber = s.PhoneNumber
                    }).ToList();
                string temp;
                DateTime date = new DateTime();
                studentGeneralInformation.Add(student[0].firstName.ToString());
                studentGeneralInformation.Add(student[0].lastName.ToString());
                if(student[0].DOB != null)
                {
                    temp = student[0].DOB.ToString();
                    date = Convert.ToDateTime(temp);
                }
                studentGeneralInformation.Add(date.ToShortDateString());
                studentGeneralInformation.Add(student[0].phoneNumber);

                return studentGeneralInformation;
            }
            catch (Exception)
            {

                throw new FormatException();
            }
        }

        // returns list of students for the datagrid in studentControl
        public List<Student> GetStudentsByClass(int classId)
        {
            List<Student> students = new List<Student>();
            var studentList = _context.StudentClasses.Where(sc => sc.ClassId == classId).Select(sc => sc.Student).ToList();
            foreach (var student in studentList)
            {
                students.Add(student);
            }
            return students;
        }

        // add new studen to DB
        public void AddStudent(Student student)
        {
            _context.Set<Student>().Add(student);

        }

        // create new account for new member - must have one-to-one connection
        public Account CreateStudentAccount(Student student)
        {
            Account userAccount = new Account();
            userAccount.UserName = student.FirstName.ToLower() + student.LastName.ToLower();
            userAccount.Password = student.FirstName.ToLower() + student.LastName.ToLower() + "123";
            var userExist = _context.Accounts.Where(u => u.UserName == userAccount.UserName).Any();
            while (userExist)
            {
                userAccount.UserName += "0";
            }
            _context.Set<Account>().Add(userAccount);
            _context.SaveChanges();
            return userAccount;
        }

        public List<string> GetAllStudentsNames()
        {
            var students = _context.Students.Select(s => s.FirstName + " " + s.LastName).ToList();
            return students;
        }

        public Student GetStudentByFullName(string fullName)
        {
            var student = _context.Students.Where(s => s.FirstName + " " + s.LastName == fullName)
                .Select(s => s)
                .FirstOrDefault();
            return student;
        }

        public void DeleteStudent(Student student)
        {
            _context.Set<Student>().Remove(student);

            //Now if we removed student we need to remove him or her from all classes related

            var studentClass = _context.StudentClasses.Where(sc => sc.StudentId == student.Id).Select(sc => sc).ToList();
            foreach (var item in studentClass)
            {
                _context.Set<StudentClass>().Remove(item);
            }
        }

        #endregion


        #region Classes
        /*
         * all function here related to working with classes
        */

        public void CreateNewClass(Class newClass)
        {
            _context.Set<Class>().Add(newClass);
        }

        public void MatchStudentToClass(StudentClass studentClass)
        {
            _context.Set<StudentClass>().Add(studentClass);
        }

        public Class GetClassById(int id)
        {
            var myClass = _context.Classes.Where(c => c.ClassId == id).Select(c => c).FirstOrDefault();
            return myClass;
        }

        public void DeleteStudentFromClass(StudentClass studentClass)
        {
            _context.Set<StudentClass>().Remove(studentClass);
        }

        public StudentClass GetStudentClassMatch(int classId, int studentId)
        {
            var studentClass = _context.StudentClasses.Where(sc => sc.ClassId == classId && sc.StudentId == studentId).Select(sc => sc).FirstOrDefault();
            return studentClass;
        }

        /// <summary>
        /// Get all classes related to a crew member
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns>list of classId</returns>
        public List<int> GetClassesByTeacher(CrewMember teacher)
        {
            List<int> classes = new List<int>();

            try
            {
                using (var schoolManage = new SchoolManagementContext())
                {
                    classes = _context.Classes.Where(c => c.CrewMemberId == teacher.Id).Select(cl => cl.ClassId).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return classes;

        }

        public bool IsClassExist(int classCode)
        {
            var classExist = _context.Classes.Where(c => c.ClassCode == classCode).Any();
            return classExist;
        }

        public bool IsStudentExistInClass(int studentId, int classId)
        {
            var studenExist = _context.StudentClasses.Where(sc => sc.StudentId == studentId && sc.ClassId == classId).Any();
            return studenExist;
        }

        public void DeleteClass(int classId)
        {
            try
            {
                var studentClasses = _context.StudentClasses.Where(sc => sc.ClassId == classId).ToList();
                foreach (var studentClass in studentClasses)
                {
                    DeleteStudentFromClass(studentClass);
                }
                var myClass = _context.Classes.Where(c => c.ClassId == classId).FirstOrDefault();
                _context.Set<Class>().Remove(myClass);
            }
            catch (Exception)
            {
                throw new NullReferenceException();
            }
        }

        #endregion

    }
}
