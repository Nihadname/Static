using Static.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static.Models
{
    public class User: IAccount
    {
        private static int IdCounter;
        public int Id;
        public string FullName { get; set; }
        public string Email { get; set; }
        private string _Password;
        public string Password { get{ 
            return _Password;
            } set {
                if (PasswordChecker(value))
                {
                    _Password = value;
                    Console.WriteLine("duzdur");
                }
                else
                {
                    Console.WriteLine("sehvdir");
                }
            }
        }
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
           return regex.IsMatch(password);
            


        }

        public void ShowInfo()
        {
            Console.WriteLine($"{this.FullName} {this.Email} {this.Id} ");
        }

    }
}
