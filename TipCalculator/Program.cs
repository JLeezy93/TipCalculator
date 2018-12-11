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
                Console.WriteLine("How much is your bill?");

                string subTotal = Console.ReadLine();
                decimal convertSubTotal = Convert.ToDecimal(subTotal);

                Console.WriteLine("What percentage would you like to tip?");

                string tipAmount = Console.ReadLine();
                decimal tipAmountPercent = Convert.ToDecimal(tipAmount);
                decimal tip = tipAmountPercent * convertSubTotal;
                decimal grandTotal = convertSubTotal + tip;

                Console.WriteLine("Your tip amount is $" + tip + ".");
                Console.WriteLine("Your grand total is $" + grandTotal + ".");

                Console.WriteLine("Do you want to find the tip for another bill? (Y / N)" );
                string userAnswer = Console.ReadKey().KeyChar.ToString();

                if (userAnswer.ToLower().Equals("n"))
                {
                    break;
                } else if (userAnswer.ToLower().Equals("y"))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Great!");
                }
            }
            Console.WriteLine("\nThanks! See you later!");
            Thread.Sleep(5000);
        }
    }
}
