using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class CountingApp
    {
        static void Main()
        {
            InputReader input = new InputReader();
            input.Greeting();

            string countToUserInput = Console.ReadLine();

            Console.WriteLine($"Okay, count to {countToUserInput}. Now enter a number to count by (incrementally).");

            string countByUserInput = Console.ReadLine();

            if (countToUserInput != null && countByUserInput != null)
            {
                input.NumChecks(countToUserInput, countByUserInput);
            } 
            else
            {
                Console.WriteLine("you fucked up");
            }
        }
    }
}