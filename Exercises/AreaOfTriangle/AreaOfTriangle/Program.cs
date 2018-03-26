using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {//A Program to Calculate the Area of a Triangle Given the Length of the 3 Sides\\
            Console.Write("Please input the Length of Side A of your triangle: ");
            double SideA = double.Parse(Console.ReadLine());
            Console.Write("Please input the Length of Side B of your triangle: ");
            double SideB = double.Parse(Console.ReadLine());
            Console.Write("Please input the Length of Side c of your triangle: ");
            double SideC = double.Parse(Console.ReadLine());
            //According to Herons Theory
            double perimeter = (SideA + SideB + SideC) / 2;
            double Area = Math.Sqrt( perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
            Console.Write("The Area of Your Triangle is: {0}", Area);
            Console.ReadLine();
            
        }
    }
}
