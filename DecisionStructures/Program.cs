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
            var purchasePrice = amount * price;
            if (amount > 5 && price > 100)
            {
                if (purchasePrice > 10000)
                {
                    discount = purchasePrice * 0.2m;
                    //Console.WriteLine("Your discount is: ${0} on a ${1} purchase", discount, purchasePrice);
                    Console.WriteLine($"Your discount is: {discount:c} on a {purchasePrice:C} purchase.");
                }
                else if (purchasePrice < 10000 && purchasePrice > 1000)
                {
                    discount = purchasePrice * 0.1m;
                    Console.WriteLine("Your discount is: ${0} on a ${1} purchase", discount, purchasePrice);
                }
                else if (purchasePrice < 1000 && purchasePrice > 100)
                {
                    discount = purchasePrice * 0.05m;
                    Console.WriteLine("Your discount is: ${0} on a ${1} purchase", discount, purchasePrice);
                }
                else
                    Console.WriteLine("You do not get a discount.");
            }
            //need this final else statement or the program will fall through and crash when the first if conditions aren't met.
            else
                Console.WriteLine("You do not get a discount.");
        }
    }
}
