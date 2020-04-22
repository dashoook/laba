using System;

namespace LABA2._3._1
{
    public class Program
    {
        static public void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введiть розмiрнiсть масиву: ");
            n = int.Parse(Console.ReadLine());

            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x[" + i + "]" + ": ");
                x[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Сума непарних елементiв: " + suma(x,n));
            Console.WriteLine("Сума вiд'ємних значень: " + suma1(x,n));
            
        }
        static public int suma(int[] x, int n)
        {
            int s = 0;
            for (int i = 1; i < n; i += 2)        
                s += x[i];
            return s;
        }
        static public int suma1(int[] x, int n)
        {
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
                c += x[i];

            return c;
        }
    }
}