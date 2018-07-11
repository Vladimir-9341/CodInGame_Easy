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
            int L = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            string T = Console.ReadLine();

            const int A = (int)'A';
            const int Z = (int)'Z';

            string str = T.ToUpper();

            for (int i = 0; i < H; i++)
            {

                string row = Console.ReadLine();
                string ret = "";

                foreach (var s in str)
                {
                    var c = (int)s;

                    if (c < A || c > Z)
                        ret += row.Substring(L * (Z - A + 1), L);
                    else
                        ret += row.Substring(L * (c - A), L);
                }
                Console.WriteLine(ret);
            }
        }
    }

}
