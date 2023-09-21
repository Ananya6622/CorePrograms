using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class FlipCoin
    {
        public static void coin()
        {
            Random random = new Random();
            int headsCount = 0;
            int tailsCount = 0;

            while (headsCount < 20 && tailsCount < 20)
            {
                int result = random.Next(0, 2); // 0 for Heads, 1 for Tails

                if (result == 0)
                {
                    Console.WriteLine("Heads");
                    headsCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailsCount++;
                }
            }

            if (headsCount >= 20)
            {
                Console.WriteLine("Heads won 20 times!");
            }
            else
            {
                Console.WriteLine("Tails won 20 times!");
            }

        }
    }
}
