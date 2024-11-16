using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLab
{
    internal abstract class Person
    {
        public DateTime Birthday { get; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { 
            get 
            {
                
                var Now = DateTime.Now;
                int Age = Now.Year - Birthday.Year;
                if (Now < Birthday.AddYears(Age)) Age--;
                return Age;
            } }


        protected Person(string Name, string Surname, DateTime BirthDay)
        {
            this.Name = Name;
            this.Surname = Surname;
            if (BirthDay > DateTime.Now) throw new ArgumentOutOfRangeException("A birthday can't be into the future!");
            this.Birthday = BirthDay;
            
        }

        public override string ToString() 
        {
            return $"Name: {this.Name}\nSurname: {this.Surname}\nBirhtday: {Birthday.Date}\nAge: {Age}"; 
        }



    }
}
