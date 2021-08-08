using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Jakhongir", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}.\n");

            account.MakeWithdrawal(7700, DateTime.Now, "Car");
            account.MakeWithdrawal(500, DateTime.Now, "TV");
            account.MakeDeposit(1000, DateTime.Now, "Salary");

            Console.WriteLine(account.GetAccountHistory());

            //// Test for a negative balance
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            //// Test that the initial balances must be positive
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -100);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}
        }
    }
}
