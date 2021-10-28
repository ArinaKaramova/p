using System;

namespace p
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, m;
            Console.WriteLine("Введите первый катет");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второй катет");
            b = double.Parse(Console.ReadLine());

            c = Math.Sqrt(a * a + b * b);
            m = c / 2;

            Console.WriteLine("M = " + m);
        }
    }
}
