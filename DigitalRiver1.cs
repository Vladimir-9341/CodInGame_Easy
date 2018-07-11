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
            long r1 = long.Parse(Console.ReadLine());
            long r2 = long.Parse(Console.ReadLine());

            var f1 = Flow(r1);//Получаем поток 1
            var f2 = Flow(r2);//Получаем поток 2
            var f3 = f1.Concat(f2);//Объединяем в один поток

            //Получаем все общие элементы
            var query = f3.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();

            //Выводим первый общий элемент
            Console.WriteLine(query[0]);
            //Console.ReadLine();
        }

        static List<long> Flow(long r)
        {
            //Создаем хранилище для значений потока
            var flowlist = new List<long>();
            //Добавляем первое значение
            flowlist.Add(r);
            //получаем массив разрядов(100000 шагов)
            for (int i = 0; i < 100000; i++)
            {
                string stroka1 = r.ToString();
                int sum = 0;
                for (int j = 0; j < stroka1.Length; j++)
                {
                    sum += (int)Char.GetNumericValue(stroka1[j]);
                }
                flowlist.Add(r + sum);
                r = r + sum;
            }

            return flowlist;
        }

    }
}
