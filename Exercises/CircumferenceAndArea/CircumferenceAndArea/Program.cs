using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircumferenceAndArea
{
    class Program
    {
        static void Main(string[] args)
        { //A Program that Solves the Area and Circumference of a Circle Based of a Given Radius\\
            double radius;
            double Math.PI = 3.14159;
            double area, cir;
            Console.Write("Enter the Radius of the Circle ****");
            radius = double.Parse(Console.ReadLine());
            area = (Math.PI * radius * radius);
            cir = (2 * Math.PI * radius);
            Console.WriteLine("The Area of your Circle is...." + area);
            Console.WriteLine("The Circumference of your Circle is...." + cir);
            Console.ReadLine();

        }
    }
}
