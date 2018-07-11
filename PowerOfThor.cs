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
            string[] inputs = Console.ReadLine().Split(' ');

            int lightX = int.Parse(inputs[0]); // the X position of the light of power
            int lightY = int.Parse(inputs[1]); // the Y position of the light of power
            int initialTX = int.Parse(inputs[2]); // Thor's starting X position
            int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

            // game loop
            while (true)
            {
                int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
                                
                //Длина маршрута
                int Xput = lightX - initialTX;
                int Yput = lightY - initialTY;   
                int Put = (int)(Math.Sqrt(Xput * Xput + Yput * Yput));
                var Track = new int[Put, 2];

                //Формирование трека
                for (int i = 0; i < Put; i++)
                {
                    if (i < Math.Abs(Xput)) Track[i, 0] = 1 * Xput / Math.Abs(Xput);
                    if (i < Math.Abs(Yput)) Track[i, 1] = 1 * Yput / Math.Abs(Yput);
                }

                //Прохождение маршрута
                int r = 0;
                while (r < Put)
                {
                    
                    if (Track[r, 0] == -1 && Track[r, 1] == -1)
                        Console.WriteLine("NW");

                    if (Track[r, 0] == 1 && Track[r, 1] == -1)
                        Console.WriteLine("NE");

                    if (Track[r, 0] == 1 && Track[r, 1] == 1)
                        Console.WriteLine("SE");

                    if (Track[r, 0] == 0 && Track[r, 1] == -1)
                        Console.WriteLine("N");

                    if (Track[r, 0] == -1 && Track[r, 1] == 0)
                        Console.WriteLine("W");
                    if (Track[r, 0] == 1 && Track[r, 1] == 0)
                        Console.WriteLine("E");

                    if (Track[r, 0] == -1 && Track[r, 1] == 1)
                        Console.WriteLine("SW");
                    if (Track[r, 0] == 0 && Track[r, 1] == 1)
                        Console.WriteLine("S");
                    r++;
                }
                // A single line providing the move to be made: N NE E SE S SW W or NW
                //Console.WriteLine("SE");
            }
        }

    }
}
