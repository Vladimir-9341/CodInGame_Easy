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
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                //Вершина 1
                string A = inputs[0];
                int xA = int.Parse(inputs[1]);
                int yA = int.Parse(inputs[2]);
                Point p1 = new Point(xA,yA);
                //Вершина 2
                string B = inputs[3];
                int xB = int.Parse(inputs[4]);
                int yB = int.Parse(inputs[5]);
                Point p2 = new Point(xB, yB);
                //Вершина 3
                string C = inputs[6];
                int xC = int.Parse(inputs[7]);
                int yC = int.Parse(inputs[8]);
                Point p3 = new Point(xC, yC);
                //Вершина 4
                string D = inputs[9];
                int xD = int.Parse(inputs[10]);
                int yD = int.Parse(inputs[11]);
                Point p4 = new Point(xD, yD);

                Console.WriteLine(A+B+C+D+" is "+CheckQuadro(p1,p2,p3,p4));
            }

            //Console.ReadLine();
        }

        public static string CheckQuadro(Point p1, Point p2, Point p3, Point p4)
        {
            //public string type= "quadrilateral";
            //Стороны
            double AB = p1.GetDistanse(p2);
            double BC = p2.GetDistanse(p3);
            double CD = p3.GetDistanse(p4);
            double DA = p4.GetDistanse(p1);
            //Диагонали
            double BD = p2.GetDistanse(p4);
            double AC = p1.GetDistanse(p3);

            double Angle1 = Math.Acos((AB * AB + DA * DA - BD * BD )/ (2 * AB * DA));
            double Angle2 = Math.Acos((BC * BC + AB * AB - AC * AC) / (2 * BC * AB));
            double Angle3 = Math.Acos((DA * DA + CD * CD - AC * AC) / (2 * DA * CD));

            bool SideEqual = (AB == BC) && (BC == CD);
            bool AngleRight = (Math.Abs(Angle1-Math.PI/2)<0.01) && (Math.Abs(Angle2 -Math.PI/2)< 0.01);
            bool Parallel = (Math.Abs((Angle1 + Angle2) - Math.PI) < 0.01) &&
                    (Math.Abs((Angle1 + Angle3) - Math.PI) < 0.01);


            if (SideEqual && AngleRight) return "square";
            if (SideEqual) return "rhombus";
            if (AngleRight) return "rectangle";
            if (Parallel) return "parallelogram";

            return "quadrilateral";
        }
    }


    public class Point
    {    
        public int X, Y;

        public Point(int x, int y)
        {
            X = x; Y = y;
        }
        public double GetDistanse(Point p)
        {
            return Math.Sqrt((X - p.X) * (X - p.X) + (Y - p.Y)*(Y - p.Y));
        }
    }
}
