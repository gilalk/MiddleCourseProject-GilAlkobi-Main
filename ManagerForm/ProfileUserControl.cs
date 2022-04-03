using SchoolManagement.DB;
using SchoolManagement.DB.Models;
using System.Text.RegularExpressions;

namespace ManagerForm
{
    public partial class ProfileUserControl : UserControl
    {
        public event Action OnBackToHomeControl;
        private string userFullName = FormLogin.fullName;
        public ProfileUserControl()
        {
            InitializeComponent();
            FillInformationInLabels();
            changePasswordgrBox.Visible = false;
            changeDetailsgrBox.Visible = false;
        }

        private void FillInformationInLabels()
        {
            using(var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                var crewMember = unitOfWork.Managers.GetCrewMemberByFullName(userFullName);
                firstNamelbl.Text = crewMember.FirstName;
                lastNamelbl.Text = crewMember.LastName;
                rolelbl.Text = crewMember.Role;
                subjectlbl.Text = crewMember.Subject;
                birthDatelbl.Text = crewMember.DateOfBirth.ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.OnBackToHomeControl();
        }

        private void changePassbtn_Click(object sender, EventArgs e)
        {
            changePasswordgrBox.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using(var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                var user = unitOfWork.Managers.GetCrewMemberByFullName(userFullName);
                var account = unitOfWork.Account.GetAccount(user.AccountId);
                if(account == null)
                {
                    MessageBox.Show("User is not exist!");
                    return;
                }
                else if(string.IsNullOrEmpty(newPasswordtxt.Text) || string.IsNullOrEmpty(verifyPasswordtxt.Text) || string.IsNullOrEmpty(usernametxt.Text))
                {
                    MessageBox.Show("Enter Input First!");
                    return;
                }
                else if (!Validations.IsThisPasswordIsValid(newPasswordtxt.Text))
                {
                    MessageBox.Show("Passwod must contain at least\nOne capital letter\nOne lowercase letter\nOne number\nOne special sign\nFrom 8 to 20 characters");
                    return;
                }
                else if(newPasswordtxt.Text != verifyPasswordtxt.Text)
                {
                    MessageBox.Show("Verified password Doesn't match!");
                    return;
                }
                
                else if(account.UserName == usernametxt.Text && newPasswordtxt.Text == verifyPasswordtxt.Text)
                {
                    account.Password = verifyPasswordtxt.Text;
                    unitOfWork.Complete();
                    MessageBox.Show("Password changed!");
                    usernametxt.Clear();
                    newPasswordtxt.Clear();
                    verifyPasswordtxt.Clear();
                    changePasswordgrBox.Visible = false;
                }
                else
                {
                    MessageBox.Show("Wrong User Name!");
                }

            }
        }

        private void changeDetbtn_Click(object sender, EventArgs e)
        {
            using(var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                changeDetailsgrBox.Visible = true;
                var member = unitOfWork.Managers.GetCrewMemberByFullName(userFullName);
                firstNametxt.Text = member.FirstName;
                lastNametxt.Text = member.LastName;
                roleCmBox.Text = member.Role;
                subjectCmBox.Text = member.Subject;
                addresstxt.Text = member.Adress;
                citytxt.Text = member.City;
                emailtxt.Text = member.Email;
                phoneNumbertxt.Text = member.PhoneNumber;

                if(FormLogin.role != "manager" && FormLogin.role != "deputy director")
                {
                    roleCmBox.Enabled = false;
                    subjectCmBox.Enabled = false;
                }
            }
        }

        private void saveDetsbtn_Click(object sender, EventArgs e)
        {
            using(var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                var member = unitOfWork.Managers.GetCrewMemberByFullName(userFullName);
                member.FirstName = firstNametxt.Text;
                member.LastName = lastNametxt.Text;
                member.Role = roleCmBox.Text;
                member.Subject = subjectCmBox.Text;
                member.Adress = addresstxt.Text;
                member.City = citytxt.Text;
                member.PhoneNumber = phoneNumbertxt.Text;
                if(emailtxt.Text != "" && phoneNumbertxt.Text != "")
                {
                    if (!Validations.IsThisPhoneNumberValid(phoneNumbertxt.Text) && !Validations.IsThisEmailValid(emailtxt.Text))
                    {
                        MessageBox.Show("Invalid Phone Number and Email Address!");
                    }
                }
                
                if(!Validations.IsThisEmailValid(emailtxt.Text) && emailtxt.Text != "")
                {
                    MessageBox.Show("Invalid Email Address!");
                    return;
                }
                if (!Validations.IsThisPhoneNumberValid(phoneNumbertxt.Text) && phoneNumbertxt.Text != "")
                {
                    MessageBox.Show("Invalid Phone Number!");
                    return;
                }
                if (!Validations.IsThisTextContainsNoNumbers(firstNametxt.Text))
                {
                    MessageBox.Show("First name is invalid\nMust contain no numbers!");
                    return;
                }
                if (!Validations.IsThisTextContainsNoNumbers(lastNametxt.Text))
                {
                    MessageBox.Show("Last name is invalid\nMust contain no numbers!");
                    return;
                }

                MessageBox.Show("Details Saved Successfully!");
                unitOfWork.Complete();
                firstNametxt.Clear();
                lastNametxt.Clear();
                roleCmBox.ResetText();
                subjectCmBox.ResetText();
                addresstxt.Clear();
                citytxt.Clear();
                phoneNumbertxt.Clear();
                changeDetailsgrBox.Visible = false;
            }
        }


        #region ErrorProviders with Regex

        private void emailtxt_TextChanged(object sender, EventArgs e)
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

        private void phoneNumbertxt_TextChanged(object sender, EventArgs e)
        {
            if (!Validations.IsThisPhoneNumberValid(phoneNumbertxt.Text))
            {
                phoneNumberErrorProvider1.SetError(phoneNumbertxt, "Wrong Format!");
            }
            else
            {
                phoneNumberErrorProvider1.Clear();
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
