using SchoolManagement.DB;
using SchoolManagement.DB.Models;

namespace ManagerForm
{
    public partial class FormLogin : Form
    {
        public static Users tempCrewMember { get; set; }
        public static string role;
        public static string fullName;
        public static Form LoginForm;
        public FormLogin()
        {
            InitializeComponent();
            LoginForm = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    var user = unitOfWork.Account.Login(usernametxt.Text, passwordtxt.Text);
                    if(user.Student == null && user.crewMember == null)
                    {
                        throw new UserNotExistException();
                    }
                    else if (user.Student == null)
                    {
                        role = user.crewMember.Role;
                        fullName = user.crewMember.FirstName + " " + user.crewMember.LastName;
                        var myManageForm = new manageForm();
                        
                        myManageForm.Show();
                        this.Visible = false;
                    }

                }
            }
            catch (UserNotExistException)
            {

                MessageBox.Show("This User is not Exist!");
            }

        }
    }
}
