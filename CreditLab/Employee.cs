using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLab
{
    internal abstract class Employee : Person //промежуточный класс, который описывает сущность работника
    {

        private decimal sellaryPerMoth;
        public decimal SellaryPerMonth { get => sellaryPerMoth; set => sellaryPerMoth = value < 0 ? 0 : value; }

        readonly DateTime HiringDate;

        public int Experience { 
            get 
            {
                var Now = DateTime.Now;
                int Age = Now.Year - HiringDate.Year;
                if (Now < HiringDate.AddYears(Age)) Age--;
                return Age;
            }}



        //здесь я решил не углубляться в рассчет зарплаты, а решил просто взять среднее значение рабочих дней в месяце
        public decimal GetSellary(uint days) => sellaryPerMoth * days / 20m;

        public Employee(string Name, string Surname, DateTime BirthDay, DateTime HiringDate, decimal sellaryPerMoth) : base(Name, Surname, BirthDay)
        {
            this.SellaryPerMonth = sellaryPerMoth;
            if (HiringDate > DateTime.Now) throw new ArgumentOutOfRangeException("A hiring date can't be into the future!");
            this.HiringDate = HiringDate;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nSallary: {this.SellaryPerMonth}\nExperience: {this.Experience};";
        }


    }
}
