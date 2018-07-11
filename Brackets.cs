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
            string expr = Console.ReadLine();
            var expression = expr.ToCharArray().ToList();
            bool answer = true;

            for (int i = 0; i < expression.Count; i++)
            {
                if (expression[i] == '{')
                {
                    for (int j = i; j < expression.Count; j++)
                    {
                        if (expression[j] == '}')
                        {
                            expression[i] = 'x';
                            expression[j] = 'x';
                            break;
                        }
                    }
                }

                else if (expression[i] == '[')
                {
                    for (int j = i; j < expression.Count; j++)
                    {
                        if (expression[j] == ']')
                        {
                            expression[i] = 'x';
                            expression[j] = 'x';
                            break;
                        }
                    }
                }

                else if (expression[i] == '(')
                {
                    for (int j = i; j < expression.Count; j++)
                    {
                        if (expression[j] == ')')
                        {
                            expression[i] = 'x';
                            expression[j] = 'x';
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < expression.Count; i++)
            {
                if (expression[i] == '{' ||
                    expression[i] == '}' ||
                    expression[i] == '(' ||
                    expression[i] == ')' ||
                    expression[i] == '[' ||
                    expression[i] == ']')
                {
                    answer = false;
                }
            }

            if (answer)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            //Console.ReadLine();
        }
    }
}
