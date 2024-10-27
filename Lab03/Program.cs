namespace Lab03
{
    public struct Point
    {
        public int x;
        public int y;

        public int quadraticDistance(Point p) 
        { 
            int dist = (p.x - this.x) * (p.x - this.x) + (p.y - this.y) * (p.y - this.y);
            return dist;
        }
    }
    public class Round
    {
        public Point roundCenter;
        public int radius;

        public bool IsPointInRound(Point p) 
        {
            int qDistance = this.roundCenter.quadraticDistance(p);
            if (qDistance < radius * radius) { Console.WriteLine("\nInside!"); return true; }
            if (qDistance == radius * radius) { Console.WriteLine("\nOn the line!"); return true; }
            return false;
        }
    }

    public class Zone : Round 
    {
        public int score;
    }

    public class Field
    {
        public int maxX;
        public int minX;

        public int maxY;
        public int minY;
        
        public Field (int _maxX, int _maxY)
        {
            if (_maxX <= 0 || _maxY <= 0) throw new ArgumentOutOfRangeException("Max value of a coordinate system axis can't be less than \"0\" or equals it.");
            this.maxX = _maxX;
            this.maxY = _maxY;
            this.minX = -_maxX;
            this.minY = -_maxY;

        }
    }

    

    public class Target : Field
    {
        public Point targetCenter;
        public List<Round> zones = [];
        public int[] points = { 10, 5, 1 };


        public Target( int maxX = 5, int maxY = 5, int zonesCount = 3) : base (maxY, maxX)
        {

            Random random = new Random();
            Point targetCenter = new Point() 
            {
               x = random.Next((minX + 3), (maxX + 1 - 3)),
               y = random.Next((minY + 3), (maxY + 1 - 3))
            };
            for (int i = 1; i <= zonesCount; i++) 
            {
                Round zone = new Zone() 
                { 
                    roundCenter = targetCenter,
                    radius = i,
                    score = zonesCount != i ? (zonesCount - i) * 5 : 1
                };
                zones.Add(zone);
            } 
                       
        }

        private int InputValue(string axisName)
        {
            while (true)
            {
                int x;
                Console.WriteLine($"Input {axisName} coordinate of a shoot from {this.minX} to {this.maxX}:");
                if (!Int32.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine($"\nWrong format data!\nYou need input an integer from {this.minX} to {this.maxX}.\nTry again!");
                    continue;
                }
                if (x < this.minX || x > this.maxX)
                {
                    Console.WriteLine($"\nInputed data is out of range!\nYou need input an integer from {this.minX} to {this.maxX}.\nTry again!\n");
                    continue;
                }
                return x;
            }
        }

        public int Shoot(int? num = null) 
        {
            Random rnd = new Random();
            int _x = this.InputValue("X") + rnd.Next(-1, 2);
            int _y = this.InputValue("Y") + rnd.Next(-1, 2);
            Point shootPoint = new Point() { x = _x, y = _y };
            foreach (Zone zone in zones) 
            {
                if (zone.IsPointInRound(shootPoint)) 
                {
                    Console.WriteLine($"Shoot{num} x:{shootPoint.x}, y:{shootPoint.y} - {zone.score} score\n");
                    return zone.score;
                }
            }

            Console.WriteLine($"\nOut of the target! \nShoot: x:{shootPoint.x}, y:{shootPoint.y} - 0 score\n");
            return 0;

        }

    }


    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Game start! \nYou have 3 shoots!\n");
            Target trg = new Target();
            int totalScore = 0;
            for (int i = 0; i < 3; i++) 
            {
                totalScore += trg.Shoot(i+1);
            }
            Console.WriteLine($"\nYour total score: {totalScore}");
        }
    }
}
