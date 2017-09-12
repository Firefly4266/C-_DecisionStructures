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
            Console.Write("Hello user, please enter the price of the item purchased: ");
            var itemPrice = Console.ReadLine();
            var price = decimal.Parse(itemPrice);
            Console.Write("How many products did you purchase at this price? ");
            var itemAmount = Console.ReadLine();
            var amount = decimal.Parse(itemAmount);
            if (amount > 5 && price > 100)
            {
                Console.WriteLine("You get a discount!");
            }
            else
                Console.WriteLine("You do not get a discount.");
        }
    }
}
