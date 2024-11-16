using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLab
{
    internal class Teacher : Employee, IEmployee
    {
        public string Faculty { get; set; }
        public string Post { get; set; }
        public Teacher(string Name, string Surname, DateTime BirthDay, DateTime HiringDate, decimal sellaryPerMoth, string faculty, string post ) : base(Name, Surname, BirthDay, HiringDate, sellaryPerMoth)
        {
            this.Faculty = faculty;
            this.Post = post;
        }

        public bool WorkDone()
        {
            try
            {

                Console.WriteLine("Starting a lesson.");
                Console.WriteLine("Lesson...");
                Console.WriteLine("Finish the lesson.");
                Console.WriteLine("Ring!");
                return true;
            }
            catch
            {
                Console.WriteLine("The lesson did not take place");
                return false;
            }
        }

        public override string ToString()
        {
            return $"Teacher\nFaculty: {this.Faculty}\nPost: {this.Post}\n{base.ToString()}\n";
        }
    }
}
