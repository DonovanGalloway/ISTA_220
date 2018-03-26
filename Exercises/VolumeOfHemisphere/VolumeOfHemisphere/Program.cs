using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfHemisphere
{
    class Program
    {
        static void Main(string[] args)
        {//A Program to Attain the Volume of a Hemisphere given the Radius\\
            double r, volume;
            double PI = 3.14;
            Console.Write("Enter the Radius of a Hemisphere Here:");
            r = Convert.ToDouble(Console.ReadLine());
            volume = (4 / 3) * PI * r * r * r;
            Console.WriteLine("Volume of Sphere is : {0}", volume);
            Console.Read();
        }
    }
}
