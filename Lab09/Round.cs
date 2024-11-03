using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    internal class Round : Shape
    {
        public double Radius { get; private set; }

        public Round(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException("A radius can't be less or equals zero!");
            Radius = radius;
        }

        public override double Sqrt() => Math.PI * Radius * Radius;

        public override double Perimiter() => 2 * Math.PI * Radius;

        public override void Show() => Console.WriteLine($"\nThe round radius: {Radius}\nThe round length: {Perimiter()}\nThe round area: {Sqrt()}");
    }
}
