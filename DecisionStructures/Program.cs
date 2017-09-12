using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello user, what is your favorite number?  ");
            var userInput = Console.ReadLine();
            var input = int.Parse(userInput);

            if (input > 1000)
                Console.WriteLine("Wow! That's a big number.");
            else if (input < 0)
                Console.WriteLine("Don't be so negative");
            else
                Console.WriteLine("That's a nice number.");
        }
    }
}
