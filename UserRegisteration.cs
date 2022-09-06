using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionPracticeProblem
{
    public class UserRegisteration
    {
           //UC1
        public static string Regex_FirstName = "^[A-Z]{5}$";
        //UC2
        public static string Regex_LastName = "^[A-Z]{4}$";
        //UC4
        public static string Regex_MobileNumber = "^[0-9]{10}$";
        //UC5 to UC8
        public static string Regex_Email = @"^[a-z]{5}[@][a-z]{5}[.][a-z]{3}$";
        //UC3 and UC9
        public static string Regex_Password = "^[A-Z]{1}[a-z]{4}[@][0-9]{2}$";

        public bool ValidateFirstName(string firstName)
        {
            try
            {
                if (firstName.Equals(string.Empty))
                {
                    throw new UserException(UserException.ExceptionType.Empty_Message, "Name should not be empty.");
                }
                else if (Regex.IsMatch(firstName, Regex_FirstName))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserException(UserException.ExceptionType.NULL_Message, "Name should not be null.");
            }

        }
        public bool ValidateLastName(string lastName)
        {
            try
            {
                if (Regex.IsMatch(lastName, Regex_LastName))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.Empty_Message, "Last name should not be empty.");
            }
        }
        public bool ValidateEmail(string email)
        {
            try
            {
                if (Regex.IsMatch(email, Regex_Email))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.Empty_Message, "Email should not be empty.");

            }
        }
        public bool ValidateMobileNumber(string mobile)
        {
            try
            {
                if (Regex.IsMatch(mobile, Regex_MobileNumber))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserException(UserException.ExceptionType.Empty_Message, "Mobile number should not be empty.");

            }
        }
        public bool ValidatePassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, Regex_Password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.Empty_Message, "Password should not be empty.");
            }
        }

    }
}
