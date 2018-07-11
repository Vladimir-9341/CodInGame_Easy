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
            int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
            string[] inputs = Console.ReadLine().Split(' ');
            int[] inp = new int[n];
            int[] inp2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                inp[i] = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
                inp2[i] = Math.Abs(inp[i]);
            }

            if (inp2.Count() != 0)
            {
                int min = inp2.Min();
                int ind = Array.IndexOf(inp2, min);

                if (inp[ind] < 0)
                {
                    bool b = Array.Exists(inp, element => element == -inp[ind]);
                    if (b) ind = Array.IndexOf(inp, min);
                }

                Console.WriteLine(inp[ind]);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
