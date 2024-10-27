namespace Lab04._2
{
    internal class Program
    {
        public static int SqrEquation (double a, double b, double c, ref double root1, ref double root2) 
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0) 
            {
                root1 = (-b + Math.Sqrt(d))/(2 * a);
                root2 = (-b - Math.Sqrt(d)) / (2 * a);
                return 1;
            }
            if (d == 0)
            {
                root1 = root2 = -b / (2 * a);
                return 0;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            double root1 = 0, root2 = 0;
            int[] coefs = new int[3];
            string sequence ="";
            for (int i = 0; i < coefs.Length; i++)
            {
                switch (i)
                {
                    case 0: sequence = "1st"; break;
                    case 1: sequence = "2nd"; break;
                    case 2: sequence = "3rd"; break;

                }
                Console.WriteLine($"Input {sequence} coefficient of the quadratic equation:");
                coefs[i] = Int32.Parse(Console.ReadLine());
            }
            int result = SqrEquation(coefs[0], coefs[1], coefs[2],ref root1,ref root2);
            switch(result)
            {
                case -1: Console.WriteLine($"The roots of the equation with coefficients: a = {coefs[0]}, b = {coefs[1]}, c = {coefs[2]}, don't exist"); ; break;
                case 0: Console.WriteLine($"The root of the equation with coefficients: a = {coefs[0]}, b = {coefs[1]}, c = {coefs[2]}, is one: x1 = x2 = {root1}"); ; break;
                case 1: Console.WriteLine($"The roots of the equation with coefficients: a = {coefs[0]}, b = {coefs[1]}, c = {coefs[2]}, are equal: x1 = {root1}, x2 = {root2}"); ; break;
            }
        }
    }
}
