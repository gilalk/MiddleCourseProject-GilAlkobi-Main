using SchoolManagement.DB;
using SchoolManagement.DB.Models;
using System.Text.RegularExpressions;

namespace ManagerForm
{
    public partial class AddStudentControl : UserControl
    {
        
        // an event which helps me move between user controls
        public event Action? OnBackToUserControl;

        public AddStudentControl()
        {
            InitializeComponent();
        }

        
        // add the new students 
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
                    Student student = new Student();
                    student.FirstName = firstNametxt.Text;
                    student.LastName = lastNametxt.Text;
                    student.Gender = gendercmBox.Text;
                    student.DateOfBirth = birthDatePicker.Value;
                    student.Age = dateTime.Year - birthDatePicker.Value.Year;
                    student.Address = addresstxt.Text;
                    student.City = citytxt.Text;

                    student.EmergacyContactName = emergencytxt.Text;

                    student.Email = emailtxt.Text;

                    student.PhoneNumber = phoneNumbertxt.Text;

                    if (!Validations.IsThisEmailValid(emailtxt.Text) && emailtxt.Text != "") { 
                        MessageBox.Show("Email Address is Invalid!");
                        return;
                    }
                    if (!Validations.IsThisPhoneNumberValid(phoneNumbertxt.Text) && phoneNumbertxt.Text != "") {
                        MessageBox.Show("Phone Number is Invalid!");
                        return;
                    }
                    if (!Validations.IsThisPhoneNumberValid(emergencytxt.Text) && emergencytxt.Text != "") {
                        MessageBox.Show("Emergancy Contact's Phone Number is Invalid!");
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

                    // create account for current user
                    var newAccount = unitOfWork.Managers.CreateStudentAccount(student);

                    // insert student's accountId
                    student.AccountId = newAccount.Id;

                    // Add the student
                    unitOfWork.Managers.AddStudent(student);

                    // save changes
                    unitOfWork.Complete();

                    MessageBox.Show("Student added successfully!");
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
            emergencytxt.Clear();
            addresstxt.Clear();
            citytxt.Clear();
            emailtxt.Clear();
            phoneNumbertxt.Clear();
            birthDatePicker.ResetText();
        }

       
        // go back to previous user control
        private void backbtn_Click(object sender, EventArgs e)
        {
            this.OnBackToUserControl();

        }

        #region ErrorProviders with Regex

        private void emergencytxt_TextChanged(object sender, EventArgs e)
        {
            if (!Validations.IsThisPhoneNumberValid(emergencytxt.Text))
            {
                phoneNumErrorProvider1.SetError(emergencytxt, "Wrong Format!");
            }
            else
            {
                phoneNumErrorProvider1.Clear();
            }
        }

        private void phoneNumbertxt_TextChanged(object sender, EventArgs e)
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
