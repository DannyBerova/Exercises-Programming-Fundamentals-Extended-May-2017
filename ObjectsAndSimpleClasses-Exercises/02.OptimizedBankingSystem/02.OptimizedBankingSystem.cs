
namespace _02.OptimizedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class BankAccount
    {
        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<BankAccount> accounts = new List<BankAccount>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(new string[] { " | " },
                    StringSplitOptions.RemoveEmptyEntries);

                string bank = tokens[0];
                string name = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                BankAccount newAccount = new BankAccount
                {
                    Bank = bank,
                    Name = name,
                    Balance = balance
                };

                accounts.Add(newAccount);

                inputLine = Console.ReadLine();
            }

            var accountsForPrint = accounts
                .OrderByDescending(acc => acc.Balance)
                .ThenBy(acc => acc.Bank.Length)
                .ToList();

            foreach (var account in accountsForPrint)
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }
    }
}
