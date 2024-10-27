namespace Lab04
{
    public class Operation
    {
        private static bool IsTriangleExs(double a, double b, double c) 
        {
            if (a + b > c && a + c > b && b + c > a ) return true;
            else return false;
        }

        public static double TriangleSqr(double a, double b, double c) 
        {
            if (!IsTriangleExs(a, b, c)) throw new ApplicationException("The triangle doesnt exist");
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        public static double TriangleSqr(double side) 
        {
            double p = side * 3 / 2;
            double s = Math.Sqrt(p * Math.Pow((p - side), 3));
            return s;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A triangl is equilateral (0 - No, 1 - Yes):");
            bool isel = Convert.ToBoolean(Int32.Parse(Console.ReadLine()));
            double s;
            if (isel)
            {
                Console.WriteLine("Input the trangle's side:");
                int side = Int32.Parse(Console.ReadLine());
                s = Operation.TriangleSqr(side);
            }
            else 
            {
                string sequence = "";
                int[] sides = new int[3];
                for (int i = 0; i < sides.Length; i++)
                {
                    switch (i)
                    {
                        case 0: sequence = "1st"; break;
                        case 1: sequence = "2nd"; break;
                        case 3: sequence = "3rd"; break;

                    }
                    Console.WriteLine($"Input {sequence} side of the triangl:");
                    sides[i] = Int32.Parse(Console.ReadLine());
                }
                s = Operation.TriangleSqr(sides[0], sides[1], sides[2]);
            }
            Console.WriteLine($"The area of the triangle is {s}");
        }
    }
}
