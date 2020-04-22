using System;

namespace LABA2._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Enter n for x[n,m]: ");
            n = int.Parse(Console.ReadLine());
            while (n < 0)
            {
                Console.WriteLine("Reenter n for x[n,m]: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter m for x[n,m]: ");
            m = int.Parse(Console.ReadLine());
            while (m < 0)
            {
                Console.WriteLine("Reenter m for x[n,m]: ");
                m = int.Parse(Console.ReadLine());
            }
            int[,] x = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    x[i,j] = rnd.Next(-100, 100);
                    Console.WriteLine("x[" + i + "," + j + "]: " + x[i,j]);
   
                }
            }
            Console.WriteLine("Geometrical mean is " + geom(n, m, x));
        }

        static public double geom(int n, int m, int[,] x)
        {
            int a = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a *= x[i, j];
                }
            }
            double b, c;
            c = 1.0 / (n * m);
            b = Math.Pow(a, c);
            return b;
        }
    }
 }
