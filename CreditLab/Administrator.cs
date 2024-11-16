using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLab
{
    internal class Administrator : Employee, IEmployee
    {
        public ushort LabNumber { get; set; }
        public Administrator(string Name, string Surname, DateTime BirthDay, DateTime HiringDate, decimal Salary, ushort LabNumber) : base(Name, Surname, BirthDay, HiringDate, Salary)
        {
            this.LabNumber = LabNumber;
        }
        public bool WorkDone()
        {
            try
            {

                Console.WriteLine($"Starting of prepearing laboratory of number {LabNumber}.");
                Console.WriteLine($"Prepearing laboratory of number {LabNumber}...");
                Console.WriteLine($"Laboratory of number {LabNumber} is ready!");

                return true;
            }
            catch
            {
                Console.WriteLine("Laboratory of number {LabNumber} is NOT ready!");
                return false;
            }
        }

        public override string ToString()
        {
            return $"Administrator of laboratory of number {this.LabNumber}\n{base.ToString()}\n";
        }
    }
}
