using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if (a + b > c)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("equilateral");
                }
                else if ((a * a + b * b - c * c) < 0.000001 || (b * b + c * c - a * a) < 0.000001 || (c * c + a * a - b * b) < 0.000001)
                {
                    Console.WriteLine("right-angled");
                }
                else if ((a == b) || (b == c) || (c == a))
                {
                    Console.WriteLine("isosceles");
                }
                else
                {
                    Console.WriteLine("notspecial");
                }
            }
            else
            {
                Console.WriteLine("invalid");
            }
            Console.ReadKey();
        }
    }
}
