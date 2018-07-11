using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] mount = new int[8];

            // game loop
            while (true)
            {
                int max = 0;
                for (int i = 0; i < 8; i++)
                {
                    int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                    mount[i] = mountainH;
                    max = Math.Max(mountainH, max);
                }

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");


                Console.WriteLine(Array.IndexOf(mount, max)); // The index of the mountain to fire on.
            }
        }

    }

}
