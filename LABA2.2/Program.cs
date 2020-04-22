
using System;

namespace LABA2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;
            double y;
            Console.WriteLine("Введiть межу а в [a,b]: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть межу b в [a,b]: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть крок: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Результати обчислення функцiї y(x) на промiжку ["+a+";" + b +"] з кроком " +c);
            while (a<b)
            {
                a += c;
                if (a > 0)
                {
                    y = Math.Log10(a) / a;
                    Console.WriteLine("\n" + a + "\t"+ y);
                }
                else
                {
                    Console.WriteLine("\n" + a + "\tНемає результату");
                }
            }
        }
    }
}
