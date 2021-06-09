using System;

namespace JoeAndBobCash
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates new Guy objects
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            while (true)
            {
                // Displays guy info
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                // Prompts for amount
                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "")
                    return;
                if (int.TryParse(howMuch, out int amount))
                {
                    // Determines who cash is coming from / going to
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();

                    if (whichGuy == "Joe")
                    {
                        int giveAmount = joe.GiveCash(amount);
                        bob.ReceiveCash(giveAmount);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int giveAmount = bob.GiveCash(amount);
                        joe.ReceiveCash(giveAmount);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit): ");
                }
            }
        }
    }
}
