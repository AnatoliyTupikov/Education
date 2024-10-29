namespace Lab06
{
    public class Triangle
    {
        public int Side1 { get; private set; }
        public int Side2 { get; private set; }
        public int Side3 { get; private set; }

        public Triangle(int side1, int side2, int side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        public bool IsTriangleExs()
        {
            if (this.Side1 + this.Side2 > this.Side3 && this.Side1 + this.Side3 > this.Side2 && this.Side2 + this.Side3 > this.Side1) return true;
            
            else return false;
        }

        public int TrianglePer() 
        {
            if (!this.IsTriangleExs()) throw new ApplicationException("The triangle can't exist");
            return this.Side1 + this.Side2 + this.Side3;
        }

        public double TriangleSqr()
        {
            double p = (double)(this.TrianglePer() / 2);
            double s = Math.Sqrt(p * (p - this.Side1) * (p - this.Side2) * (p - this.Side3));
            return s;
        }

        public void PrintTriangle()
        {
            Console.WriteLine($"The trianle's 1st side: {this.Side1}");
            Console.WriteLine($"The trianle's 2nd side: {this.Side2}");
            Console.WriteLine($"The trianle's 3rd side: {this.Side3}\n");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Triangle tr = new Triangle(4, 5, 7);
            Triangle notExistTr = new Triangle(1, 2, 30);

            tr.PrintTriangle();
            Console.WriteLine("Perimiter = " + tr.TrianglePer());
            Console.WriteLine("Squere = " + tr.TriangleSqr() + "\n");
            

            notExistTr.PrintTriangle();
            notExistTr.TrianglePer();
            
        }
    }
}
