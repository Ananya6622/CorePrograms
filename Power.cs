using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class Power
    {
        public static void power()
        {
            Console.WriteLine("Enter a value for 'n': ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0)
            {
                Console.WriteLine("Powers of 2 less than or equal to 2^n:");

                for (int i = 0; i <= n; i++)
                {
                    long powerOf2 = (long)Math.Pow(2, i);
                    Console.WriteLine($"2^{i} = {powerOf2}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. 'n' must be a non-negative integer.");
            }
        }
    }
}
