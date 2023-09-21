using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class SumOfNaturalNumbers
    {
        public static void sum()
        {
            int n = 5;
            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Sum of the first " + n + " natural numbers is: " + sum);

        }
    }
}
