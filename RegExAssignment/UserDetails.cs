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
        public string _emailPattern = "^(abc+[a-z._+-]*)+@bl.co.[a-z]{2,}$";
        
        /// <summary>Validate user inputs</summary>
        /// <param name="input">Raw Value</param>
        /// <param name="pattern">Regular Expression</param>
        /// <returns>Returns a bool value</returns>
        public bool CheckStatus(string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }

        public void tempInput()
        {
            string firstName = "Shuvam";
            string lastName = "Das";
            string email = "abc+shuvam@bl.co.com";
            
            if(!CheckStatus(firstName, _namePattern))
                throw new Exception($"{firstName} pattern matching failed");
            
            if(!CheckStatus(lastName, _namePattern))
                throw new Exception($"{lastName} pattern matching failed");
            
            if(!CheckStatus(email, _emailPattern))
                throw new Exception($"{email} pattern matching failed");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Results");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);
            Console.WriteLine("Email: " + email);
        }
        
        public void Solution()
        {
            /*
             // uc-1 User's First Name validation
            Console.Write("First Name = ");
            string firstName = Console.ReadLine();
            
            if(!CheckStatus(firstName, _namePattern))
                throw new Exception($"{firstName} pattern matching failed");
            
            // uc-2 User's Last Name validation
            Console.Write("Last Name = ");
            string lastName = Console.ReadLine();
            if(!CheckStatus(lastName, _namePattern))
                throw new Exception($"{lastName} pattern matching failed");
            
            // uc-3 User's Email validation
            Console.Write("Email = ");
            string email = Console.ReadLine();
            if(!CheckStatus(email, _emailPattern))
                throw new Exception($"{email} pattern matching failed");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Results");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);
            Console.WriteLine("Email: " + email);
            */
            tempInput();
        } 
    }
}