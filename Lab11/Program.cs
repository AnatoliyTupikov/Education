using System;

namespace Lab02
{
    public class Distance
    {
        public int foot { get; set; }
        private int _inch;

        public int inch
        {
            get { return _inch; }
            set 
            {
                foot += value / 12;
                int clearValue = value / 12 == 0 ? value : value % 12;
                
                if (clearValue > 0 && foot < 0)
                {
                    foot++;
                    _inch = -12 + clearValue;
                }
                else 
                {
                    if (foot > 0 && clearValue < 0)
                    {
                        foot--;
                        _inch = 12 + clearValue;
                    }
                    else _inch = clearValue;
                }
                
                
                
            }
        }


        public Distance(){ }

        public Distance(int foot, int inch)
        {
            this.foot = foot;
            this.inch = inch;
        }

        public static Distance operator + (Distance a) => a;
        public static Distance operator - (Distance a) => new Distance(-a.foot, -a.inch);
        public static Distance operator + (Distance a, Distance b) => new Distance(a.foot + b.foot, a.inch + b.inch);
        public static Distance operator - (Distance a, Distance b) => new Distance(a.foot - b.foot, a.inch - b.inch);

        //private static bool IsFootEquals (Distance a, Distance b) => a.foot == b.foot;
        public static bool operator ==(Distance a, Distance b) => (a.foot == b.foot && a.inch == b.inch);
        public static bool operator != (Distance a, Distance b) => !(a == b);
        public static bool operator > (Distance a, Distance b) => (a.foot > b.foot || (a.foot == b.foot && a.inch > b.inch));
        public static bool operator < (Distance a, Distance b) => (a.foot < b.foot || (a.foot == b.foot && a.inch < b.inch));

        public static bool operator >= (Distance a, Distance b) => (a > b || a == b);
        public static bool operator <= (Distance a, Distance b) => (a < b || a == b);
        





        public override string ToString() => $"{this.foot}'— {this.inch}\"";
        
       
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            var dist1 = new Distance() { foot = - 72, inch = - 12 };
            var dist2 = new Distance() { foot = - 72, inch = - 12 };

            var dist3 = dist1 + dist2;
            var dist4 = dist2 - dist1;

            Console.WriteLine($"dist1 = dist2? {dist1 == dist2}");
            Console.WriteLine($"dist1 != dist2? {dist1 != dist2}");
            Console.WriteLine($"dist1 > dist2? {dist1 > dist2}");
            Console.WriteLine($"dist1 < dist2? {dist1 < dist2}");
            Console.WriteLine($"dist1 >= dist2? {dist1 >= dist2}");
            Console.WriteLine($"dist1 <= dist2? {dist1 <= dist2}");


            Console.WriteLine(dist1);
            Console.WriteLine(dist2);
            Console.WriteLine(dist3);
            Console.WriteLine(dist4);
            
        }
    }
}

