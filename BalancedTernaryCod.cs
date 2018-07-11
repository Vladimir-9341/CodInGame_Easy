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
            int num = int.Parse(Console.ReadLine());
            var x = ToTrenary(num);

            Console.WriteLine(x);
            //Console.ReadLine();
        }

        public static String ToTrenary(int value)
        {
            if (value == 0)
                return "0";

            StringBuilder Sb = new StringBuilder();
            Boolean signed = false;


            if (value < 0)
            {
                signed = true;
                value = -value;
            }

            //Преобразование в симметричный троичный код
            while (value > 0)
            {
                if (value % 3 == 2)
                {
                    Sb.Insert(0, 'T');
                    value = value / 3 + 1;
                }
                else
                {
                    Sb.Insert(0, value % 3);
                    value /= 3;
                }
            }

            //Если отрицательное число - меняем символы
            if (signed)
            {
                for (int i = 0; i < Sb.Length; i++)
                {
                    if (Sb[i] == 'T')
                    {
                        Sb[i] = '1';

                    }
                    else if (Sb[i] == '1')
                    {
                        Sb[i] = 'T';
                    }
                }
            }

            return Sb.ToString();
        }
    }
}
