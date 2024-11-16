using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLab
{
    internal class Manager : Employee, IEmployee
    {
        public string Faculty { get; set; }
        public string Post { get; set; }
        public Manager(string Name, string Surname, DateTime BirthDay, DateTime HiringDate, decimal sellaryPerMoth, string faculty, string post) : base(Name, Surname, BirthDay, HiringDate, sellaryPerMoth)
        {
            this.Faculty = faculty;
            this.Post = post;
        }

        public bool WorkDone()
        {
            try
            {

                Console.WriteLine("Starting a work.");
                Console.WriteLine("Working...");
                Console.WriteLine("Finish the work.");
                return true;
            }
            catch
            {
                Console.WriteLine("The work isn't done");
                return false;
            }
        }

        public override string ToString()
        {
            return $"Manager\nFaculty: {this.Faculty}\nPost: {this.Post}\n{base.ToString()}\n";
        }
    }
}
