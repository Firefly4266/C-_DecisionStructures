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
            Console.Write("Hello user, quick question...what is the result of 8 * 5?  ");
            var userInput = Console.ReadLine();
            var input = int.Parse(userInput);
            Console.WriteLine((input != 40) ? "Thanks, I had a brain freeze!" : "I don't think that right, I'll shoot one of my kids a text...they'll know.");
        }
    }
}
