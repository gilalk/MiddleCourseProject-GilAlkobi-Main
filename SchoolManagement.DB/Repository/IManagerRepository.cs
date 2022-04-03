using SchoolManagement.DB.Models;

namespace SchoolManagement.DB
{
    public interface IManagerRepository : ICrewMemberRepository
    {

        //CrewMembers
        void AddCrewMember(CrewMember member);
        Account CreateCrewMemberAccount(CrewMember member);
        List<string> GetAllCrewMembersNames();
        List<CrewMember> GetAllCrewMembers();
        List<string> GetTeachersNames();
        void CreateNewClass(Class newClass);


        //Students
        void AddStudent(Student student);
        List<string> GetAllStudentsNames();
        Student GetStudentByFullName(string fullName);
        void DeleteStudent(Student student);
        Account CreateStudentAccount(Student student);


        //Classes
        void MatchStudentToClass(StudentClass studentClass);
        void DeleteStudentFromClass(StudentClass studentClass);
        StudentClass GetStudentClassMatch(int classId, int studentId);
        Class GetClassById(int id);
        bool IsClassExist(int classCode);
        bool IsStudentExistInClass(int studentId, int classId);
        //void DeleteAllStudentsFromClass(Class exClass);
        void DeleteClass(int classId);
    }
}
