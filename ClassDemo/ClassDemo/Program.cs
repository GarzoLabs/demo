using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var account = new BankAccount("Hector Garzo", 1200);
                Console.WriteLine("Account has benn created");
                account.Deposit(300, DateTime.Now, "Receive this month's salary");
                account.Withdraw(100, DateTime.Now, "Buy a keyboard");
                account.Withdraw(120, DateTime.Now, "Buy a mouse");
                account.Withdraw(-300, DateTime.Now, "Receive a fail");
                account.Withdraw(1500, DateTime.Now, "Buy a laptop");

                Console.WriteLine("Finish trnsactions");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error = "+e.Message);
            }
            
        }
    }
}
