using System;

namespace p
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = XY(3, 11) + XY(5, 13) + XY(7, 17);
            Console.WriteLine(Math.Round(x, 3));
        }
        static double XY(double n1, double n2)
        {
            return (1 + Math.Pow(n1, 2)) / (1 + Math.Pow(n2, 2));
        }
    }
}
