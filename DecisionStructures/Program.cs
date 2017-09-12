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
            Console.Write("Hello user, please input a number and I'll tell you if it's even or odd: ");
            var userInput = Console.ReadLine();
            var input = int.Parse(userInput);
            if (input % 2 == 0)
                Console.WriteLine("Your number is even");
            else
                Console.WriteLine("Your number is odd.");
        }
    }
}
