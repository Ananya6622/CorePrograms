using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class SumOfSquares
    {
        public static void sum()
        {
            Console.WriteLine("Enter a number 'N': ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N >= 1)
            {
                int sumOfSquares = 0;

                for (int i = 1; i <= N; i++)
                {
                    int square = i * i;
                    sumOfSquares += square;
                }

                Console.WriteLine($"The sum of squares of the first {N} numbers is: {sumOfSquares}");
            }
            else
            {
                Console.WriteLine("Invalid input. 'N' must be a positive integer.");
            }
        }
    }
}
