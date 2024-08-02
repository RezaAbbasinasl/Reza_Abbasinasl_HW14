using System.Text.RegularExpressions;

namespace Reza_Abbasinasl_HW14.Validation
{
    public static class Validation
    {
        public static bool ValidationNameAndFamily(this string name)
        {
            if (name == null) return false;
            int length = name.Length;
            if (length >= 3 && length <= 30)
            {
                return true;
            }
            return false;
        }
        public static bool ValidationPhoneNumber(this string phoneNumber)
        {
            if(phoneNumber == null) return false;
            string phoneNumberPattern = @"^09\d{9}$";
            int length = phoneNumber.Length;
            Regex regex = new Regex(phoneNumberPattern);
            if (length == 11 && regex.IsMatch(phoneNumber))
            {
                return true;
            }
            return false;
        }
        public static bool ValidationPermissibleAge(this DateTime date)
        {
            DateTime newDate = DateTime.Now;
            if ((newDate.Year - date.Year >= 18) || (newDate.Month -date.Month > 0) || (newDate.Day - date.Day > 0))
            {
                return true;
            }
            return false;
        }
        public static bool ValidationCourseCode(this int courseCode)
        {
            string cours = Convert.ToString(courseCode);
            int length = cours.Length;
            if (length == 3 && cours[2] % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool ValidationGenderCzheck(this string gender)
        {
            if (gender == "Man" || gender == "Female")
            {
                return true;
            }
            return false;
        }
        public static bool ValidationCheckRules(this bool checkRules)
        {
            if (checkRules == true)
            {
                return true;
            }
            return false;
        }
    }
}
