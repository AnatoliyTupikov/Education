namespace Lab09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quadr = new Quadrant(13.33);
            var triang = new Triangle(13, 17, 12);
            var triangravn = new Triangle(7);
            var round = new Round(2616.212);

            quadr.Show();
            quadr.Rotate();

            triang.Show();
            triang.Rotate();

            triangravn.Show();
            triangravn.Rotate();

            round.Show();
            
        }
    }
}
