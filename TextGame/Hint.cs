using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class Hint
    {
       
        public static int HintEvenNumbers(int number)
        {
            int tries = 0;
            if (number % 2 ==0 )
            {
                Console.WriteLine("This is your 4th attempt. Here is the first hint: numer is even");

                if (tries > 3 && number >= 50 && number % 2 == 0)
                {
                    Console.WriteLine("The number is in the range of 50-100 ");
                }
                else if (tries > 3 && number <= 50 && number % 2 == 0)
                {
                    Console.WriteLine("The number is in the range of 1-50 ");
                }
            }
            else
            {
                Console.WriteLine("This is your 4th attempt. Here is the first hint: numer is not even");

                if (tries > 3 && number >= 50 && number % 2 == 1)
                {
                    Console.WriteLine("The number is in the range of 50-100 ");
                }
                else if (tries > 3 && number <= 50 && number % 2 == 1)
                {
                    Console.WriteLine("The number is in the range of 1-50 ");
                }
            }
            return tries;
        }
    }
}
