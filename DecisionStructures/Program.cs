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
            decimal discount;
            Console.Write("Hello user, please enter the price of the item purchased: ");
            var itemPrice = Console.ReadLine();
            var price = decimal.Parse(itemPrice);
            Console.Write("How many products did you purchase at this price? ");
            var itemAmount = Console.ReadLine();
            var amount = decimal.Parse(itemAmount);
            var purchacePrice = amount * price;
            if (amount > 5 && price > 100)
            {
                if (purchacePrice > 10000)
                {
                    discount = purchacePrice * 0.2m;
                    Console.WriteLine("Your discount is: ${0} on a ${1} purchase", discount, purchacePrice);
                }
                else if (purchacePrice < 10000 && purchacePrice > 1000)
                {
                    discount = purchacePrice * 0.1m;
                    Console.WriteLine("Your discount is: ${0} on a ${1} purchase", discount, purchacePrice);
                }
                else if (purchacePrice < 1000 && purchacePrice > 100)
                {
                    discount = purchacePrice * 0.05m;
                    Console.WriteLine("Your discount is: ${0} on a ${1} purchase", discount, purchacePrice);
                }
                else
                    Console.WriteLine("You do not get a discount.");
            }
        }
    }
}
