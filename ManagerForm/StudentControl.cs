using SchoolManagement.DB;
using SchoolManagement.DB.Models;

namespace ManagerForm
{
    public partial class StudentControl : UserControl
    {

        public event Action<AddStudentControl> OnChangeUserControl;
        public event Action<EditStudentControl> OnChangeStudentControl;
        public StudentControl()
        {
            InitializeComponent();
            ChangeVisibilityOfLabels(false);
            Permissions();
        }

        private void Permissions()
        {
            if (FormLogin.role == "manager" || FormLogin.role == "deputy director")
            {
                addbtn.Enabled = true;
                editbtn.Enabled = true;
                FillTeachercmBox();
            }
            else
            {
                addbtn.Enabled = false;
                editbtn.Enabled = false;
                techercmBox.Items.Add(FormLogin.fullName);
            }
        }

        private void FillTeachercmBox()
        {
            using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                var crewMembers = unitOfWork.Managers.GetTeachersNames();
                foreach (var crewMember in crewMembers)
                {
                    techercmBox.Items.Add(crewMember);
                }
            }
        }

        private void ChangeVisibilityOfLabels(bool visible)
        {
            if (visible == true)
            {
                firstNamelbl.Visible = true;
                lastNamelbl.Visible = true;
                DOBlbl.Visible = true;
                phoneNumberlbl.Visible = true;
            }
            else
            {
                firstNamelbl.Visible = false;
                lastNamelbl.Visible = false;
                DOBlbl.Visible = false;
                phoneNumberlbl.Visible = false;
            }
        }

        private void ZeroizeAllBoxes()
        {
            techercmBox.ResetText();
            classcmBox.ResetText();
            studentcmBox.ResetText();
            ChangeVisibilityOfLabels(false);
            selectAllCheckBox.Checked = false;
            fullInfoDgv.DataSource = null;
        }
        private void classcmBox_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                var teacher = unitOfWork.Managers.GetCrewMemberByFullName(techercmBox.Text);
                var classes = unitOfWork.Managers.GetClassesByTeacher(teacher);
                classcmBox.DataSource = classes;
            }
        }

        private void studentcmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                var studentsNames = unitOfWork.Managers.GetStudentsNamesByClass(Convert.ToInt32(classcmBox.Text));
                studentcmBox.DataSource = studentsNames;
            }
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    if (selectAllCheckBox.Checked)
                    {
                        var students = unitOfWork.Managers.GetStudentsByClass(Convert.ToInt32(classcmBox.Text));
                        fullInfoDgv.DataSource = students;
                        selectAllCheckBox.Checked = false;
                    }
                    else
                    {
                        var specificStudent = unitOfWork.Managers.GetGeneralInfoOnSpecificStudents(studentcmBox.Text);
                        ChangeVisibilityOfLabels(true);

                        firstNamelbl.Text = specificStudent[0];
                        lastNamelbl.Text = specificStudent[1];
                        DOBlbl.Text = specificStudent[2];
                        phoneNumberlbl.Text = specificStudent[3];
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Choose requested information first!");
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddStudentControl addStudentControl = new AddStudentControl();
            this.OnChangeUserControl(addStudentControl);

            addStudentControl.OnBackToUserControl += () =>
            {
                addStudentControl.Dispose();
                this.Visible = true;
                ZeroizeAllBoxes();
            };
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            EditStudentControl editStudentControl = new EditStudentControl();
            this.OnChangeStudentControl(editStudentControl);

            editStudentControl.OnBackToStudentControl2 += () =>
            {
                editStudentControl.Dispose();
                this.Visible = true;
                ZeroizeAllBoxes();
            };
        }
    }
}
