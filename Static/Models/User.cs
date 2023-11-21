using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static.Models
{
    public class User
    {
        public static int IdCounter;
        public int Id;
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string fullName, string email, string password)
        {
            IdCounter++;
            Id = IdCounter;
            FullName = fullName;
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            Regex regex = new Regex(passwordPattern);
            bool IsItValid = regex.IsMatch(password);
            if (IsItValid == true)
            {

                return true;
            }
            else
            {
                return false;
            }


        }

        public void ShowInfo()
        {
            Console.WriteLine($"{this.FullName} {this.Email} {this.Id} ");
        }

    }
}
