using System;

namespace Lab1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Specify perimeter of a triangle: ");
            double userPerimetr = double.Parse(Console.ReadLine());
            double p =  userPerimetr / 2;
            double trSide = userPerimetr / 3;
            double S = Math.Sqrt(p * (p - trSide) * (p - trSide) * (p - trSide));
            Console.WriteLine("Side     Square");
            Console.WriteLine($"{trSide:F2}     {S:F2}");

        }
    }
}
