namespace ManagerForm
{
    public partial class HomeUserControl : UserControl
    {
        private int helloMessage;
        public event Action<ProfileUserControl> OnChangeToProfileControl;
        public HomeUserControl()
        {
            InitializeComponent();
            PrintHelloMessage();
        }

        private async void PrintHelloMessage()
        {
            userlbl.Text = FormLogin.fullName;
            helloMessage = DateTime.Now.Hour;
            if(helloMessage >= 6 && helloMessage < 12)
            {
                hellolbl.Text = "Good Morning!";
                await Task.Delay(3000);
                hellolbl.Visible = false;
            }
            else if(helloMessage >= 12 && helloMessage < 18)
            {
                hellolbl.Text = "Good Afternoon!";
                await Task.Delay(3000);
                hellolbl.Visible = false;
            }
            else if (helloMessage >= 18 && helloMessage < 22)
            {
                hellolbl.Text = "Good Evening!";
                await Task.Delay(3000);
                hellolbl.Visible = false;
            }
            else
            {
                hellolbl.Text = "Good Night!";
                await Task.Delay(3000);
                hellolbl.Visible = false;
            }
        }

        private void myProfilebtn_Click(object sender, EventArgs e)
        {
            ProfileUserControl profileUserControl = new ProfileUserControl();
            OnChangeToProfileControl(profileUserControl);

            profileUserControl.OnBackToHomeControl += () =>
            {
                profileUserControl.Dispose();
                this.Visible = true;
            };

        }
    }
}
