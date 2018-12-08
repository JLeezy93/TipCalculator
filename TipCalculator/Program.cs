using System;


namespace TipCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Creating a console interface for tip calculator
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
        }
    }
}
