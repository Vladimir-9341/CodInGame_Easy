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
            int N = int.Parse(Console.ReadLine());
            int[] str = new int[N];
            for (int i = 0; i < N; i++)
                str[i] = int.Parse(Console.ReadLine());
            Array.Sort(str);
            str = str.Select((c, d) => (str.Length > d + 1 ? str[d + 1] - c : -1)).ToArray();
            Array.Sort(str);
            Console.Write(str[1]);
        }
    }
}
