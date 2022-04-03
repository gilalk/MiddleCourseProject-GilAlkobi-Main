using ManagerForm;
using SchoolManagement.DB;
using SchoolManagement.DB.Models;


namespace SchoolManagement_MyMidProj
{
    public partial class LoginForm : Form
    {
        public static CrewMember tempCrewMember { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    tempCrewMember = unitOfWork.Managers.Login(usernametxt.Text, passwordtxt.Text);

                    var manageForm = new manageForm();
                    manageForm.Show();
                }
            }
            catch (UserNotExistException)
            {
                MessageBox.Show("This user is not Exist!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}