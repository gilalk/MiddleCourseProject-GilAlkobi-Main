using SchoolManagement.DB;
using SchoolManagement.DB.Models;

namespace ManagerForm
{
    public partial class CrewControl : UserControl
    {
        public event Action<AddMemberControl> OnChangeMemberControl;
        public event Action<EditMemberControl> OnChangeMemberControl2;

        public CrewControl()
        {
            InitializeComponent();
            FillCrewMembersNamesInCmBox();
            ChangeVisibilityOfLabels(false);
            Permissions();

        }

        private void Permissions()
        {
            if (FormLogin.role == "manager" || FormLogin.role == "deputy director")
            {
                addbtn.Enabled = true;
                editbtn.Enabled = true;
            }
            else
            {
                addbtn.Enabled = false;
                editbtn.Enabled = false;
            }
        }
        private void FillCrewMembersNamesInCmBox()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    crewMemberscmBox.Items.Clear();
                    var crewMembers = unitOfWork.Managers.GetAllCrewMembersNames();
                    foreach (var member in crewMembers)
                    {
                        crewMemberscmBox.Items.Add(member);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured\nCouldn't load crew members list!");
            }
        }

        private void ChangeVisibilityOfLabels(bool visible)
        {
            if (visible == true)
            {
                firstNamelbl.Visible = true;
                lastNamelbl.Visible = true;
                rolelbl.Visible = true;
                subjectlbl.Visible = true;
            }
            else
            {
                firstNamelbl.Visible = false;
                lastNamelbl.Visible = false;
                rolelbl.Visible = false;
                subjectlbl.Visible = false;
            }
        }

        private void ZeroizeAllBoxes()
        {
            crewMemberscmBox.ResetText();
            selectAllcbx.Checked = false;
            sortcmbox.ResetText();
            fullInfoDGV.DataSource = null;
            ChangeVisibilityOfLabels(false);
        }

        private void dispInfobtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    if (selectAllcbx.Checked)
                    {
                        var allInfoMembers = unitOfWork.Managers.GetAllCrewMembers();
                        fullInfoDGV.DataSource = allInfoMembers;
                        selectAllcbx.Checked = false;
                    }
                    else
                    {
                        var specificInfo = unitOfWork.Managers.GetGeneralInfOnSpecificCrewMembers(crewMemberscmBox.Text);
                        ChangeVisibilityOfLabels(true);

                        firstNamelbl.Text = specificInfo[0];
                        lastNamelbl.Text = specificInfo[1];
                        rolelbl.Text = specificInfo[2];
                        subjectlbl.Text = specificInfo[3];
                    }
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Choose requested information first!");
            }
        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                var members = unitOfWork.Managers.GetAllCrewMembers();
                switch (sortcmbox.Text)
                {
                    case "Id":
                        members.Sort(new SortById());
                        fullInfoDGV.DataSource = members;
                        break;
                    case "First Name":
                        members.Sort(new SortByFirstName());
                        fullInfoDGV.DataSource = members;
                        break;
                    case "Gender":
                        members.Sort(new SortByGender());
                        fullInfoDGV.DataSource = members;
                        break;

                    default:
                        break;
                }
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddMemberControl addMemberControl = new AddMemberControl();
                this.OnChangeMemberControl(addMemberControl);

                addMemberControl.OnBackToMemberControl += () =>
                {
                    addMemberControl.Dispose();
                    this.Visible = true;
                    ZeroizeAllBoxes();
                    FillCrewMembersNamesInCmBox();
                };
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                EditMemberControl editMemberControl = new EditMemberControl();
                this.OnChangeMemberControl2(editMemberControl);

                editMemberControl.OnBackToMemberConrol2 += () =>
                {
                    editMemberControl.Dispose();
                    this.Visible = true;
                    ZeroizeAllBoxes();
                    FillCrewMembersNamesInCmBox();
                };
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}
