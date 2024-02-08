namespace MST
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Program
    {
        static double Distance(Point p1, Point p2)
        {
            double dx = p1.X - p2.X;
            double dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        static double ClosestPairDistance(Point[] points)
        {
            double minDistance = double.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = Distance(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                    }
                }
            }
            return minDistance;
        }

        static void Main(string[] args)
        {
            Point[] points = {
            new Point(0, 0),
            new Point(1, 1),
            new Point(2, 2),
            new Point(3, 3),
            new Point(4, 4)
            };

            double closestDistance = ClosestPairDistance(points);
            Console.WriteLine("Ближайшая пара точек: " + closestDistance);
        }
    }
}