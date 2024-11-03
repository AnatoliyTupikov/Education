using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    internal class Triangle : Shape, IRotatable
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(int side1, int side2, int side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0) throw new ArgumentOutOfRangeException("The side can't be less or equal zero!");
            if (!IsTriangleExs(side1, side2, side3)) throw new ArgumentOutOfRangeException("The triangel can't to excist");
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        public Triangle(int side)
        {
            if (side <= 0) throw new ArgumentOutOfRangeException("A side can't be less or equal zero!");
            this.Side1 = this.Side2 = this.Side3 = side;
        }

        public bool IsTriangleExs(double Side1, double Side2, double Side3)
        {
            if (Side1 + Side2 > Side3 && Side1 + Side3 > Side2 && Side2 + Side3 > Side1) return true;

            else return false;
        }

        public override double Perimiter()
        {
            return this.Side1 + this.Side2 + this.Side3;
        }

        public override double Sqrt()
        {
            double p = this.Perimiter() / 2;
            double s = Math.Sqrt(p * (p - this.Side1) * (p - this.Side2) * (p - this.Side3));
            return s;
        }

        public override void Show()
        {
            Console.WriteLine($"\nThe trianle's 1st side: {this.Side1}");
            Console.WriteLine($"The trianle's 2nd side: {this.Side2}");
            Console.WriteLine($"The trianle's 3rd side: {this.Side3}");
            Console.WriteLine($"The trianle perimeter: {Perimiter()}");
            Console.WriteLine($"The triangle area: {Sqrt()}");
        }

        public void Rotate() => Console.WriteLine("The triangle was rotated by 90 degrees");
    }
}
