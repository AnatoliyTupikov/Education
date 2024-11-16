using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLab
{
    internal class Student : Person, IEmployee
    {
        public string Faculty { get; set; }
        public string Group { get; set; }

        public Student( string Name, string Surname, DateTime BirthDay, string Faculty, string Group) : base(Name, Surname, BirthDay)
        {
            this.Faculty = Faculty;
            this.Group = Group;
        }

        public bool WorkDone()
        {
            try
            {

                Console.WriteLine("Starting learning.");
                Console.WriteLine("Learning...");
                Console.WriteLine("Finish learning.");
                Console.WriteLine("I've learnt.");
                return true;
            }
            catch 
            {
                Console.WriteLine("I couldn't learn it");
                return false;
            }
        }

        public override string ToString()
        {
            return $"Student\nFaculty: {this.Faculty}\nGroup: {this.Group}\n{base.ToString()}\n";
        }
    }
}
