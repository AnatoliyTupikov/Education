using System;

namespace Lab02
{
    public struct Distance
    {
        public int foot;
        public int inch;

        public static Distance Sum(Distance summand1, Distance summand2)
        {
            var result = new Distance();
            int tempInchSum = summand1.inch + summand2.inch;
            result.inch = tempInchSum % 12;
            result.foot = summand1.foot + summand2.foot + (tempInchSum / 12);
            return result;
        }

        public void Print()
        {
            Console.WriteLine($"{this.foot}'-{this.inch}\"");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            var Dist1 = new Distance() { foot = 10, inch = 11 };
            var Dist2 = new Distance() { foot = 9, inch = 5 };
            var Dist3 = Distance.Sum(Dist1, Dist2);
            Dist3.Print();
        }
    }
}

