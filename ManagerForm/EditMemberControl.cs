using SchoolManagement.DB;
using SchoolManagement.DB.Models;
using System.Text.RegularExpressions;

namespace ManagerForm
{
    public partial class EditMemberControl : UserControl
    {
        public event Action? OnBackToMemberConrol2;
        public EditMemberControl()
        {
            InitializeComponent();
            FillCrewMembersNamesInCmBox();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.OnBackToMemberConrol2();
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

        private void GetAllBoxesEmpty()
        {
            firstNametxt.Clear();
            lastNametxt.Clear();
            roleCmBox.ResetText();
            subjectTxt.ReadOnly = false;
            subjectTxt.Clear();
            subjectCmBox.ResetText();
            addresstxt.Clear();
            citytxt.Clear();
            emailtxt.Clear();
            phoneNumbertxt.Clear();
            crewMemberscmBox.ResetText();
        }

        private void crewMemberscmBox_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                var member = unitOfWork.Managers.GetCrewMemberByFullName(crewMemberscmBox.Text);
                firstNametxt.Text = member.FirstName;
                lastNametxt.Text = member.LastName;
                roleCmBox.Text = member.Role;
                subjectTxt.Text = member.Subject;
                subjectTxt.ReadOnly = true;
                addresstxt.Text = member.Adress;
                citytxt.Text = member.City;
                emailtxt.Text = member.Email;
                phoneNumbertxt.Text = member.PhoneNumber;

            }
        }

        private void saveChangesbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    if (String.IsNullOrEmpty(crewMemberscmBox.Text))
                    {
                        MessageBox.Show("Choose Member First!");
                        return;
                    }
                    var member = unitOfWork.Managers.GetCrewMemberByFullName(crewMemberscmBox.Text);
                    member.FirstName = firstNametxt.Text;
                    member.LastName = lastNametxt.Text;
                    member.Role = roleCmBox.Text;
                    member.Subject = subjectCmBox.Text;
                    member.Adress = addresstxt.Text;
                    member.City = citytxt.Text;
                    member.Email = emailtxt.Text;
                    member.PhoneNumber = phoneNumbertxt.Text;
                    if (!Validations.IsThisEmailValid(emailtxt.Text) && emailtxt.Text != "")
                    {
                        MessageBox.Show("Email Address is Invalid!");
                        return;
                    }
                    if (!Validations.IsThisPhoneNumberValid(phoneNumbertxt.Text) && phoneNumbertxt.Text != "")
                    {
                        MessageBox.Show("Phone Number is Invalid!");
                        return;
                    }
                    if (!Validations.IsThisTextContainsNoNumbers(firstNametxt.Text) && phoneNumbertxt.Text != "")
                    {
                        MessageBox.Show("First Name is Invalid\nMust contain no numbers!");
                        return;
                    }
                    if (!Validations.IsThisTextContainsNoNumbers(lastNametxt.Text) && phoneNumbertxt.Text != "")
                    {
                        MessageBox.Show("Last Name is Invalid\nMust contain no numbers!");
                        return;
                    }
                    unitOfWork.Complete();
                    MessageBox.Show("Member edited successfully!");
                    GetAllBoxesEmpty();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    if (String.IsNullOrEmpty(crewMemberscmBox.Text))
                    {
                        MessageBox.Show("Choose Member First!");
                        return;
                    }
                    var member = unitOfWork.Managers.GetCrewMemberByFullName(crewMemberscmBox.Text);
                    var account = unitOfWork.Account.GetAccount(member.AccountId);
                    string message = $"Are you sure you want to remove {member.FirstName} from system?";
                    const string caption = "Delete Member";
                    DialogResult dialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var classes = unitOfWork.Managers.GetClassesByTeacher(member);
                        if (classes != null)
                        {
                            foreach (var c in classes)
                            {
                                unitOfWork.Managers.DeleteClass(c);
                            }
                        }
                        unitOfWork.Managers.Delete(member);
                        unitOfWork.Account.Delete(account);
                        unitOfWork.Complete();
                        MessageBox.Show("Member Removed!");
                        FillCrewMembersNamesInCmBox();
                        GetAllBoxesEmpty();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }


        #region ErrorProviders with Regex

        private void phoneNumbertxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!Validations.IsThisPhoneNumberValid(phoneNumbertxt.Text))
            {
                phoneNumErrorProvider1.SetError(phoneNumbertxt, "Wrong Format!");
            }
            else
            {
                phoneNumErrorProvider1.Clear();
            }
        }

        private void emailtxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!Validations.IsThisEmailValid(emailtxt.Text))
            {
                emailErrorProvider1.SetError(emailtxt, "Wrong Format!");
            }
            else
            {
                emailErrorProvider1.Clear();
            }
        }

        private void firstNametxt_TextChanged(object sender, EventArgs e)
        {
            if (!Validations.IsThisTextContainsNoNumbers(firstNametxt.Text))
            {
                firstNameErrorProvider1.SetError(firstNametxt, "Wrong Format!");
            }
            else
            {
                firstNameErrorProvider1.Clear();
            }
        }

        private void lastNametxt_TextChanged(object sender, EventArgs e)
        {
            if (!Validations.IsThisTextContainsNoNumbers(lastNametxt.Text))
            {
                lastNameErrorProvider1.SetError(lastNametxt, "Wrong Format!");
            }
            else
            {
                lastNameErrorProvider1.Clear();
            }
        }

        #endregion

    }
}
