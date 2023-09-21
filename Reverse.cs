using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class Reverse
    {
        public static void rev()
        {
            Console.WriteLine("Enter a word: ");
            string input = Console.ReadLine();
            string reversed = "";

            int length = input.Length - 1;
            while (length >= 0)
            {
                reversed += input[length];
                length--;
            }

            Console.WriteLine("Reversed word: " + reversed);
        }
    }
}
