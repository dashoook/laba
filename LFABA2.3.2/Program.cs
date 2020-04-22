using System;

namespace LFABA2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 0;
            Console.WriteLine("Введiть розмiрнiсть масиву: ");
            n = int.Parse(Console.ReadLine());

            int[] x = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = rnd.Next(-100, 100);
                Console.WriteLine("\nx["+i+"]:"+x[i]);
            }
            for (int i = 1; i < n; i += 2)
            {
                s += x[i];
            }
            Console.WriteLine("Сума непарних елементiв: " + s);
            int a = 0, b = 0, c = 0;
            for (int i = 0; i < n; i++)
            {
                if (x[i] < 0)
                {
                    a = i;
                    break;
                }

            }
            for (int i = a; i < n; i++)
            {
                if (x[i] < 0)
                {
                    b = i;
                }
            }
            for (int i = a + 1; i < b; i++)
            {
                c += x[i];

            }
            Console.WriteLine("Сума мiж першим i останнiм вiд'ємним елементом: " + c);
        }
    }
}
