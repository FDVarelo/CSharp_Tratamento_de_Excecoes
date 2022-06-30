using System;
using System.Globalization;
using Course4.Entities;
using Course4.Entities.Exceptions;

namespace Course4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");

                Console.Write("Number: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(num, name, initialBal, limit);

                Console.Write("\nEnter value to withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(withdraw);

                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("\nError the balance!: " + e.Message);
            }

        }
    }
}