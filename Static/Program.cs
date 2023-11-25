// See https://aka.ms/new-console-template for more information
using Static.Models;
Console.WriteLine("Hello, World!");
string FullName = "Nihad Ibadzade";
string Email = "ibadzadenihad49@gmail.com";
string Password = "Password123";
User user = new(FullName, Email, Password);
Console.WriteLine(user.PasswordChecker(user.Password));
user.ShowInfo();
User user1 = new(FullName, Email, Password);
Console.WriteLine(user1.PasswordChecker(user1.Password));
user1.ShowInfo();
Student student = new(FullName,78);
student.StudentInfo();
Student student1 = new(FullName, 78);
student1.StudentInfo();