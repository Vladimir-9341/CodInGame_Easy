using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            List<double> mindistanse = new List<double>();

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                points.Add(new Point(int.Parse(inputs[0]),
                                     int.Parse(inputs[1])));
            }

            Point start = points[0];
            Point startfin = start;
            points.RemoveAt(0);

            while (points.Count > 0)
            {
                List<double> distanse = new List<double>();

                for (int i = 0; i < points.Count; i++)
                {
                    distanse.Add(start.Distanse(points[i]));
                }

                double min = distanse.Min();
                mindistanse.Add(min);
                start = points.Find(p => start.Distanse(p) == min);
                int ind = points.IndexOf(start);
                points.RemoveAt(ind);
            }

            mindistanse.Add(startfin.Distanse(start));

            int m = (int)mindistanse.Sum();

            Console.WriteLine(m);
            //Console.ReadLine();
        }

    }

    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Distanse(Point p)
        {
            int dX = p.X - X;
            int dY = p.Y - Y;

            return Math.Sqrt(dX * dX + dY * dY);
        }
    }
}
