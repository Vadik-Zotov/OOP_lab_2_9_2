using System;

namespace OOP_lab_2_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -Math.PI;

            while (x <= Math.PI)
            {
                double y = Math.Cos(x) * Math.Sin(x);

                Console.WriteLine("x = {0,7:f4}, y = {1,7:f4}", x, y);

                x += Math.PI / 10;
            }
        }
    }
}
