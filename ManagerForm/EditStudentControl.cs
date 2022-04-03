using SchoolManagement.DB;
using SchoolManagement.DB.Models;
using System.Text.RegularExpressions;

namespace ManagerForm
{
    public partial class EditStudentControl : UserControl
    {
        public event Action? OnBackToStudentControl2;
        public EditStudentControl()
        {
            InitializeComponent();
            FillStudentsNamesInCmBox();
        }

        private void FillStudentsNamesInCmBox()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
                {
                    studentcmBox.Items.Clear();
                    var students = unitOfWork.Managers.GetAllStudentsNames();
                    foreach (var student in students)
                    {
                        studentcmBox.Items.Add(student);
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
            emergencytxt.Clear();
            addresstxt.Clear();
            citytxt.Clear();
            emailtxt.Clear();
            phoneNumbertxt.Clear();
            studentcmBox.ResetText();
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            this.OnBackToStudentControl2();
        }

        private void studentcmBox_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                var student = unitOfWork.Managers.GetStudentByFullName(studentcmBox.Text);
                firstNametxt.Text = student.FirstName;
                lastNametxt.Text = student.LastName;
                emergencytxt.Text = student.EmergacyContactName;
                addresstxt.Text = student.Address;
                citytxt.Text = student.City;
                emailtxt.Text = student.Email;
                phoneNumbertxt.Text = student.PhoneNumber;
            }
        }

        private void saveChangesbtn_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                if (String.IsNullOrEmpty(studentcmBox.Text))
                {
                    MessageBox.Show("Choose Member First!");
                    return;
                }
                var student = unitOfWork.Managers.GetStudentByFullName(studentcmBox.Text);
                student.FirstName = firstNametxt.Text;
                student.LastName = lastNametxt.Text;
                student.EmergacyContactName = emergencytxt.Text;
                student.Address = addresstxt.Text;
                student.City = citytxt.Text;
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

                unitOfWork.Complete();
                MessageBox.Show("Member edited successfully!");
                GetAllBoxesEmpty();
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new SchoolManagementContext()))
            {
                if (String.IsNullOrEmpty(studentcmBox.Text))
                {
                    MessageBox.Show("Choose Member First!");
                    return;
                }
                var student = unitOfWork.Managers.GetStudentByFullName(studentcmBox.Text);
                var account = unitOfWork.Account.GetAccount(student.AccountId);
                string message = $"Are you sure you want to remove {student.FirstName} from system?";
                const string caption = "Delete Member";
                DialogResult dialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    unitOfWork.Managers.DeleteStudent(student);
                    unitOfWork.Account.Delete(account);
                    unitOfWork.Complete();
                    GetAllBoxesEmpty();
                    FillStudentsNamesInCmBox();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        #region ErrorProviders with Regex

        private void emergencytxt_TextChanged_1(object sender, EventArgs e)
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
