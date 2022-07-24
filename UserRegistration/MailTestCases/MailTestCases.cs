using System.Text.RegularExpressions;

namespace TestEmail
{
    public class Tests
    {
        [Test]
        public void CheckUserInputEmailToEmailRegex()
        {
            UserRegistration.RegularExpression regex = new UserRegistration.RegularExpression();
            string[] inputId = System.IO.File.ReadAllLines(@"C:\Users\hp\Documents\Repository\UserRegistration-Regex\UserRegistration\UserRegistration\ValidMails.txt");
            foreach (string input in inputId)
            {
                Assert.IsTrue(regex.email(input));
            }
        }
        [Test]
        public void CheckInvalidUserInputEmailToEmailRegex()
        {
            UserRegistration.RegularExpression regex = new UserRegistration.RegularExpression();
            string[] inputId = System.IO.File.ReadAllLines(@"C:\Users\hp\Documents\Repository\UserRegistration-Regex\UserRegistration\UserRegistration\Invalid.txt");
            foreach (string input in inputId)
            {
                Assert.IsFalse(regex.email(input));
            }
        }
    }
}