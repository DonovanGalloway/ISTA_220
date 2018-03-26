using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2ASumOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of Ten Numbers. ");
            int sum = 0;
            int count = 0;
            get_sums();
            Console.WriteLine($"The sum of your numbers {sum}. ");

            void get_sums()
            {
                count++;
                Console.WriteLine($"Enter the Number {count}: ");
                sum += int.Parse(Console.ReadLine());
                if (count < 10)
                    get_sums();
                else
                    return;
            }
                

        }
    }
}
