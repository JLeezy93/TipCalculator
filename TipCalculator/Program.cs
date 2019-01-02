using System;
using System.Threading;

namespace TipCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Creating a console interface for tip calculator
            while (true)
            {
                Console.WriteLine("\nHow much is your bill?");

                string subTotal = Console.ReadLine();
                decimal convertSubTotal = Convert.ToDecimal(subTotal);

                Console.WriteLine("\nWhat percentage would you like to tip?");

                string tipAmount = Console.ReadLine();
                decimal tipAmountPercent = (Convert.ToDecimal(tipAmount)) / 100;
                decimal tip = tipAmountPercent * convertSubTotal;
                decimal grandTotal = convertSubTotal + tip;

                Console.WriteLine("\nYour tip amount is $" + tip + ".");
                Console.WriteLine("Your grand total is $" + grandTotal + ".");

                Console.WriteLine("\nDo you want to find the tip for another bill? (Y / N)");
                string userAnswer = Console.ReadKey().KeyChar.ToString();

                if (userAnswer.ToLower().Equals("n"))
                {
                    break;
                } else if (userAnswer.ToLower().Equals("y"))
                {
                    Console.WriteLine("\nGreat!");
                }
            }
            Console.WriteLine("\nThanks! See you later!");
            Thread.Sleep(5000);
        }
    }
}
