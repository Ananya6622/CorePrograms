using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class EqualOrNot
    {
        public static void equality()
        {
            Console.WriteLine("enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("they are equal!");
            }
            else
            {
                Console.WriteLine("They are not equal!");
            }
        }
    }
}
