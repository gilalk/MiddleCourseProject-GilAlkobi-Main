using SchoolManagement.DB;
using SchoolManagement.DB.Models;
using System.Text.RegularExpressions;

namespace ManagerForm
{
    public partial class AddMemberControl : UserControl
    {

        // an event which helps me move between user controls
        public event Action? OnBackToMemberControl;

        public AddMemberControl()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.OnBackToMemberControl();
        }

        // add the new crewmember
        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    if (String.IsNullOrEmpty(firstNametxt.Text) || String.IsNullOrEmpty(lastNametxt.Text))
                    {
                        MessageBox.Show("First name or Last name is missing");
                        return;
                    }
                    DateTime dateTime = DateTime.Now;
                    CrewMember crewMember = new CrewMember();
                    crewMember.FirstName = firstNametxt.Text;
                    crewMember.LastName = lastNametxt.Text;
                    crewMember.Gender = gendercmBox.Text;
                    crewMember.Role = rolCmBox.Text;
                    crewMember.Subject = subjectCmBox.Text;
                    crewMember.Adress = addresstxt.Text;
                    crewMember.City = citytxt.Text;
                    crewMember.Email = emailtxt.Text;
                    crewMember.PhoneNumber = phoneNumbertxt.Text;
                    crewMember.DateOfBirth = birthDatePicker.Value;
                    crewMember.Age = dateTime.Year - birthDatePicker.Value.Year;

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

                    var newAccount = unitOfWork.Managers.CreateCrewMemberAccount(crewMember);

                    crewMember.AccountId = newAccount.Id;

                    unitOfWork.Managers.AddCrewMember(crewMember);

                    unitOfWork.Complete();

                    MessageBox.Show("Member added successfully!");
                    GetAllBoxesEmpty();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("One of your detail is improper");
            }
        }

        /// <summary>
        /// Reset all fields in screen
        /// </summary>
        private void GetAllBoxesEmpty()
        {
            firstNametxt.Clear();
            lastNametxt.Clear();
            gendercmBox.ResetText();
            rolCmBox.ResetText();
            subjectCmBox.ResetText();
            addresstxt.Clear();
            citytxt.Clear();
            emailtxt.Clear();
            phoneNumbertxt.Clear();
            birthDatePicker.ResetText();
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
