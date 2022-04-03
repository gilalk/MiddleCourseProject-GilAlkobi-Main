using System.Text.RegularExpressions;

namespace ManagerForm
{
    public class Validations
    {
        public static bool IsThisEmailValid(string emailAdress)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(emailAdress);
        }

        public static bool IsThisPhoneNumberValid(string phoneNumber)
        {
            Regex regex = new Regex(@"^([0-9]{10}|\d{10})$");
            return regex.IsMatch(phoneNumber);
        }

        public static bool IsThisTextContainsNoNumbers(string text)
        {
            Regex regex = new Regex(@"[a-zA-Z]+$");
            return regex.IsMatch(text);
        }

        public static bool IsThisPasswordIsValid(string password)
        {
            Regex regex = new Regex(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,20}$");
            return regex.IsMatch(password);
        }
    }
}
