using System;

namespace p
{
    class Program
    {
        static void Main(string[] args)
        {

            double y, x;
            Console.WriteLine("Введите x:");
            x = double.Parse(Console.ReadLine());

            y = (Math.Sqrt(Math.Sin(x) * Math.Sin(x) + 4) + Math.Tan(x)) / (Math.Cos(x) * Math.Cos(x) + 4);
            Console.WriteLine("y =" + y);
        }
    }
}
