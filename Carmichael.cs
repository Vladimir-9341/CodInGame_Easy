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

            //Получаем простые числа и находим среди них делители числа
            List<int> spisok = generatePrimes(100);
            List<int> deliteli = new List<int>();

            //Формируем список делителей
            for (int i = 0; i < spisok.Count; i++)
            {
                if (n % spisok[i] == 0)
                    deliteli.Add(spisok[i]);
            }

            //Если делителей больше одного - проверяем является ли числом Кармайкла
            if (deliteli.Count > 1)
            {
                var Kar = deliteli.Where(element => (n - 1) % (element - 1) == 0);
                if (Kar.Count() == deliteli.Count)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        //Генератор простых чисел
        static List<int> generatePrimes(int toGenerate)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            primes.Add(3);
            while (primes.Count < toGenerate)
            {
                int nextPrime = (primes[primes.Count - 1]) + 2;
                while (true)
                {
                    bool isPrime = true;
                    foreach (int n in primes)
                    {
                        if (nextPrime % n == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        break;
                    }
                    else
                    {
                        nextPrime += 2;
                    }
                }
                primes.Add(nextPrime);
            }
            return primes;
        }
    }
}
