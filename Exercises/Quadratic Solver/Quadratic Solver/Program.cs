using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Solver
{
    class Program
    {
        static void Main(string[] args)
        { //To solve the equation of ax^2+bx+c=0
            float a, b, c;
            Console.WriteLine("ax^2 + bx + c = 0");
            Console.WriteLine("Enter the coefficient for a, b, and c.");

            Console.Write("Input the coefficient of a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the coefficient of b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the coefficient of c : ");
            c = Convert.ToInt32(Console.ReadLine());
            {
                double part1xPos = -b + Math.Sqrt((b * b) - (4 * a * c));
                double xPos = part1xPos / (2 * a);
                double part1xNeg = -b - Math.Sqrt((b * b) - (4 * a * c));
                double xNeg = part1xNeg / (2 * a);

                Console.WriteLine($"The value of x is equal to {xPos} or {xNeg}");
                Console.ReadLine();
            }
        }
    }
}