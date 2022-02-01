using System;
using System.Text.RegularExpressions;

namespace RegExAssignment
{
    /// <summary>
    /// Collect valid user details wih the help of RegEx
    /// </summary>
    public class UserDetails
    {
        public string _namePattern = "^[A-Z]{1}[a-z]{2,}$";
        /// <summary>Validate user inputs</summary>
        /// <param name="input">Raw Value</param>
        /// <param name="pattern">Regular Expression</param>
        /// <returns>Returns a bool value</returns>
        public bool CheckStatus(string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }
        
        public void Solution()
        {
            // uc-1 User's First Name validation
            string firstName = Console.ReadLine();
            
            if(!CheckStatus(firstName, _namePattern))
                throw new Exception("Pattern Matching failed");
            
            // Result
            Console.WriteLine("FirstName: " + firstName);
        } 
    }
}