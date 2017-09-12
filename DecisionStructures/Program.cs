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
            Console.WriteLine(" Hello user, I have some choices for you. Please choose the appropriate number.\n");
            Console.Write(" What is your favorite State?  1.) Washington, 2.) Shock, 3.) Dismay, 4.) None of the above:  ");
            var userInput = Console.ReadLine();
            Console.WriteLine();
            var input = int.Parse(userInput);

            switch (input)
            {
                case 1:
                    Console.WriteLine(" Me also! Washington is just barely inching out Illinois, my home state, for the top spot.\n");
                    break;
                case 2:
                    Console.WriteLine(" After todays news I can see why!!!\n");
                    break;
                case 3:
                    Console.WriteLine(" I know, but praying for guidance will help!\n");
                    break;
                case 4:
                    Console.WriteLine(" So tell me again, why do you live here?\n");
                    break;
                default:
                    Console.WriteLine(" You have to chose a number.\n");
                    break;
            }
        }
    }
}
