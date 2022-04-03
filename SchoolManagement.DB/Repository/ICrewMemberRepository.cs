using SchoolManagement.DB.Models;

namespace SchoolManagement.DB
{

    public class StudentGeneralInfo
    {
        public string? firstName;
        public string? lastName;
        public DateTime? DOB;
        public string? phoneNumber;

    }
    public class CrewMemberGeneralInfo
    {
        public string? firstName;
        public string? lastName;
        public string? role;
        public string? subject;
    }
    public interface ICrewMemberRepository : IGenericRepository<CrewMember>
    {
        List<Student> GetStudentsByClass(int classId);
        List<string> GetGeneralInfoOnSpecificStudents(string studentFullName);
        List<int> GetClassesByTeacher(CrewMember teacher);
        CrewMember GetCrewMemberByFullName(string fullName);
        List<string> GetStudentsNamesByClass(int classId);
        List<string> GetGeneralInfOnSpecificCrewMembers(string crewMemberFullName);

    }
}
