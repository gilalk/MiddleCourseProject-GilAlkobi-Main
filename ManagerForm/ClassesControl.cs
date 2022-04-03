using SchoolManagement.DB;
using SchoolManagement.DB.Models;

namespace ManagerForm
{
    public partial class ClassesControl : UserControl
    {
        public ClassesControl()
        {
            InitializeComponent();
            FillCrewMembersNamesInCmBox();
            FillStudentsNamesInCmBox();
        }

        private void FillCrewMembersNamesInCmBox()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    teacherCmBox.Items.Clear();
                    teacherCmBox2.Items.Clear();
                    teacherCmBox3.Items.Clear();
                    var crewMembers = unitOfWork.Managers.GetAllCrewMembersNames();

                    foreach (var member in crewMembers)
                    {
                        teacherCmBox.Items.Add(member);
                        teacherCmBox2.Items.Add(member);
                        teacherCmBox3.Items.Add(member);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured\nCouldn't load crew members list!");
            }
        }

        private void FillStudentsNamesInCmBox()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    studentsCmBox.Items.Clear();
                    var students = unitOfWork.Managers.GetAllStudentsNames();
                    foreach (var student in students)
                    {
                        studentsCmBox.Items.Add(student);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured\nCouldn't load crew members list!");
            }
        }


        private void ClearAllFields()
        {
            teacherCmBox.ResetText();
            teacherCmBox2.ResetText();
            teacherCmBox3.ResetText();
            subjectCmBox.ResetText();
            classesCmBox.ResetText();
            classesCmBox2.ResetText();
            studentsCmBox.ResetText();
            studentsCmBox2.ResetText();
            classCodetxt.Clear();
            classNametxt.Clear();
        }

        //Create new class
        private void createClassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    Class newClass = new Class();
                    CrewMember crewMember = new CrewMember();
                    crewMember = unitOfWork.Managers.GetCrewMemberByFullName(teacherCmBox.Text);
                    newClass.CrewMemberId = crewMember.Id;
                    newClass.SubjectName = subjectCmBox.Text;
                    int result;
                    if (int.TryParse(classCodetxt.Text, out result))
                    {
                        newClass.ClassCode = result;
                    }
                    else
                    {
                        throw new invalidClassCodeException();
                    }
                    if (unitOfWork.Managers.IsClassExist(int.Parse(classCodetxt.Text)))
                    {
                        MessageBox.Show("Class Code is Already Exist!");
                        return;
                    }
                    newClass.ClassName = classNametxt.Text;
                    unitOfWork.Managers.CreateNewClass(newClass);
                    unitOfWork.Complete();
                    List<string> crewMembers = new List<string>();
                    crewMembers = unitOfWork.Managers.GetAllCrewMembersNames();
                    teacherCmBox2.DataSource = crewMembers;
                    ClearAllFields();
                    MessageBox.Show("Class Added Successfully!");
                }
            }
            catch (invalidClassCodeException)
            {
                MessageBox.Show("Invalid Class Code\nPlease Enter Only Numbers!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }


        // add classes to comboBox for matching student to class
        private void classesCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    var teacher = unitOfWork.Managers.GetCrewMemberByFullName(teacherCmBox2.Text);
                    var classes = unitOfWork.Managers.GetClassesByTeacher(teacher);
                    classesCmBox.DataSource = classes;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }


        // add classes to comboBox for removing student from class
        private void classesCmBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    var teacher = unitOfWork.Managers.GetCrewMemberByFullName(teacherCmBox3.Text);
                    var classes = unitOfWork.Managers.GetClassesByTeacher(teacher);
                    classesCmBox2.DataSource = classes;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        //Add students names to comboBox by teacher
        private void studentsCmBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    studentsCmBox2.Items.Clear();
                    var students = unitOfWork.Managers.GetStudentsNamesByClass(int.Parse(classesCmBox2.Text));
                    foreach (var student in students)
                    {
                        studentsCmBox2.Items.Add(student);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }

        }

        // Match student to class
        private void matchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    if (String.IsNullOrEmpty(teacherCmBox2.Text))
                    {
                        MessageBox.Show("Choose teacher first!");
                        return;
                    }
                    var chosenClass = unitOfWork.Managers.GetClassById(int.Parse(classesCmBox.Text));
                    var student = unitOfWork.Managers.GetStudentByFullName(studentsCmBox.Text);
                    StudentClass studentClass = new StudentClass();
                    studentClass.ClassId = chosenClass.ClassId;
                    studentClass.StudentId = student.Id;

                    if (unitOfWork.Managers.IsStudentExistInClass(student.Id, chosenClass.ClassId))
                    {
                        MessageBox.Show("This Student is Already in This Class!");
                        return;
                    }
                    unitOfWork.Managers.MatchStudentToClass(studentClass);
                    unitOfWork.Complete();
                    MessageBox.Show("Match Succeeded!");
                    classesCmBox.ResetText();
                    teacherCmBox2.ResetText();
                    studentsCmBox.ResetText();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something Went Wrong!");
            }
        }

        // Rematch student from class
        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    if (String.IsNullOrEmpty(teacherCmBox3.Text))
                    {
                        MessageBox.Show("Choose teacher first!");
                        return;
                    }
                    int classId = int.Parse(classesCmBox2.Text);
                    var student = unitOfWork.Managers.GetStudentByFullName(studentsCmBox2.Text);
                    int studentId = student.Id;
                    var match = unitOfWork.Managers.GetStudentClassMatch(classId, studentId);
                    unitOfWork.Managers.DeleteStudentFromClass(match);
                    unitOfWork.Complete();
                    MessageBox.Show("Student Removed From Class Successfully!");
                    teacherCmBox3.ResetText();
                    classesCmBox2.ResetText();
                    studentsCmBox2.ResetText();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something Went Wrong!");
            }
        }

        private void subjectCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    var member = unitOfWork.Managers.GetCrewMemberByFullName(teacherCmBox.Text);
                    subjectCmBox.Text = member.Subject;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Attach Subject to Member First!");
            }
        }
    }
}
