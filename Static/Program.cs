// See https://aka.ms/new-console-template for more information
using Static.Models;
Console.WriteLine("Hello, World!");
string FullName = "Nihad Ibadzade";
string Email = "ibadzadenihad49@gmail.com";
string Password = "Password123";
User user = new(FullName, Email, Password);
Console.WriteLine(user.PasswordChecker(Password));
user.ShowInfo();
User user1 = new(FullName, Email, Password);
Console.WriteLine(user1.PasswordChecker(Password));
user1.ShowInfo();
