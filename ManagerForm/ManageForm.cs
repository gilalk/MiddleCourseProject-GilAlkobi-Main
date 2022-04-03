

namespace ManagerForm
{
    public partial class manageForm : Form
    {
        public HomeUserControl homeUserControl = new HomeUserControl();

        public manageForm()
        {
            InitializeComponent();
            screensPanel.Controls.Add(homeUserControl);
            homeUserControl.OnChangeToProfileControl += (newUser) =>
            {
                homeUserControl.Visible = false;
                screensPanel.Controls.Add(newUser);
            };
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            nevigatePanel.Height = homeBtn.Height;
            nevigatePanel.Top = homeBtn.Top;
            screensPanel.Controls.Clear();
            screensPanel.Controls.Add(homeUserControl);
            homeUserControl.Dock = DockStyle.Fill;
        }

        private void crewBtn_Click(object sender, EventArgs e)
        {
            nevigatePanel.Height = crewBtn.Height;
            nevigatePanel.Top = crewBtn.Top;
            screensPanel.Controls.Clear();
            CrewControl crewControl1 = new CrewControl();
            screensPanel.Controls.Add(crewControl1);
            crewControl1.Dock = DockStyle.Fill;

            crewControl1.OnChangeMemberControl += (newUser) =>
            {
                crewControl1.Visible = false;
                screensPanel.Controls.Add(newUser);
            };
            crewControl1.OnChangeMemberControl2 += (newUser) =>
            {
                crewControl1.Visible = false;
                screensPanel.Controls.Add(newUser);
            };
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            nevigatePanel.Height = studentsBtn.Height;
            nevigatePanel.Top = studentsBtn.Top;
            screensPanel.Controls.Clear();
            StudentControl studentControl = new StudentControl();
            screensPanel.Controls.Add(studentControl);
            studentControl.Dock = DockStyle.Fill;

            studentControl.OnChangeUserControl += (newUser) =>
            {
                studentControl.Visible = false;
                screensPanel.Controls.Add(newUser);
            };
            studentControl.OnChangeStudentControl += (newUser) =>
            {
                studentControl.Visible = false;
                screensPanel.Controls.Add(newUser);
            };
        }
        private void classBtn_Click(object sender, EventArgs e)
        {
            if(FormLogin.role == "manager" || FormLogin.role == "deputy director")
            {
                nevigatePanel.Height = classBtn.Height;
                nevigatePanel.Top = classBtn.Top;
                screensPanel.Controls.Clear();
                ClassesControl classesControl = new ClassesControl();
                screensPanel.Controls.Add(classesControl);
                classesControl.Dock = DockStyle.Fill;
            }
            else
            {
                classBtn.Enabled = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.ShowDialog();
            this.Close();
        }

    }
}