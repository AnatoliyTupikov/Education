using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    internal class Quadrant : Shape, IRotatable
    {
        public double Side { get; private set; }

        public Quadrant(double side)
        {
            if (side <= 0) throw new ArgumentOutOfRangeException("A side can't be less or equal zero!");
            Side = side;
        }

        public override double Perimiter() => 4 * Side;
        
               
        public override double Sqrt() => Side * Side;

        public override void Show() => Console.WriteLine($"\nThe quadrant with side: {Side} \nPerimiter: {Perimiter()} \nThe area of the quadrant: {Sqrt()}" );

        public void Rotate() => Console.WriteLine("The quadrant was rotated by 90 degrees");

    }
}
