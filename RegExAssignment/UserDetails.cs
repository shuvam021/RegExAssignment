using System;
using System.Text.RegularExpressions;

namespace RegExAssignment
{
    /// <summary>
    /// Collect valid user details wih the help of RegEx
    /// </summary>
    public class UserDetails
    {
        private string _msg = "Error: value '{0}' doesn't match with pattern";
        public string _namePattern = "^[A-Z]{1}[a-z]{2,}$";
        public string _emailPattern = "^(abc+[a-z._+-]*)+@bl.co.[a-z]{2,}$";
        public string _phonePattern = "^91+( )?[0-9]{10}$";
        public string _passwordPattern = "^@([A-Z]{1,})+[a-zA-Z0-9]{8,}$";
        
        /// <summary>Validate user inputs</summary>
        /// <param name="input">Raw Value</param>
        /// <param name="pattern">Regular Expression</param>
        /// <returns>Returns a bool value</returns>
        public bool CheckStatus(string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }
        public void Result(params string[] data)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Results");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("FirstName: " + data[0]);
            Console.WriteLine("LastName: " + data[1]);
            Console.WriteLine("Email: " + data[2]);
            Console.WriteLine("Phone: " + data[3]);
            Console.WriteLine("Password: " + data[4].Replace(data[4], "********"));
        }

        public bool Validate(params string[] rawData)
        {
            bool flag = true;

            if (!CheckStatus(rawData[0], _namePattern))
            {
                Console.WriteLine(_msg, rawData[0]);
                flag = false;
            }

            if (!CheckStatus(rawData[1], _namePattern))
            {
                Console.WriteLine(_msg, rawData[1]);
                flag = false;
            }

            if (!CheckStatus(rawData[2], _emailPattern))
            {
                Console.WriteLine(_msg, rawData[2]);
                flag = false;
            }

            if (!CheckStatus(rawData[3], _phonePattern))
            {
                Console.WriteLine(_msg, rawData[3]);
                flag = false;
            }
            if (!CheckStatus(rawData[4], _passwordPattern))
            {
                Console.WriteLine(_msg, rawData[4]);
                flag = false;
            }
            return flag;
        }

        public void Solution()
        {
            /*
            // uc-1 User's First Name validation
            Console.Write("First Name = ");
            string firstName = Console.ReadLine();
            
            // uc-2 User's Last Name validation
            Console.Write("Last Name = ");
            string lastName = Console.ReadLine();

            // uc-3 User's Email validation
            Console.Write("Email = ");
            string email = Console.ReadLine();

            // uc-4 User's Email validation
            Console.Write("Email = ");
            string phone = Console.ReadLine();
            
            // uc-5 User's password validation
            Console.Write("Email = ");
            string phone = Console.ReadLine();
            */
            
            string firstName = "John";
            string lastName = "Doe";
            string email = "abc+john-doe.bridge_labz@bl.co.com";
            string phone = "91 7894561230";
            string password = "hello123";
            
            if (Validate(firstName, lastName, email, phone, password))
            {
                Result(firstName, lastName, email, phone, password);
            }
        }
    }
}