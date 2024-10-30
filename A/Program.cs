namespace A
{
    internal class Program
    {
        public static double SqrRoot(double num) 
        {
            double x = 1;
            double oldx;
            do
            {
                oldx = x;
                x = (x + num / x) / 2;
            }
            while (oldx != x);
            return x;
        }

        public static void rPrint(double num) => Console.WriteLine($"The square root of {num * num} is {num}");

        static void Main(string[] args)
        {
            double target = 2023;
            rPrint(SqrRoot(target));
            
        }
    }
}
