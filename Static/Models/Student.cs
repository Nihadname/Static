using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Models
{
    public class Student
    {
        public static int IdCounter;
        public int Id;
        public string FullName { get; set; }
        public int Point { get; set; }
        public Student(string fullname,int point)
        {
            IdCounter++;
            Id = IdCounter;
            FullName = fullname;
            Point = point;
        }
        public void  StudentInfo()
        {
            Console.WriteLine($"{this.Id} {this.FullName} {this.Point}");
        }
    }
}
