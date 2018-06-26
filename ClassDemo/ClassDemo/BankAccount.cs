using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    class BankAccount
    {
        public long AccountNumber { get; }
        public String Owner { get; set; } //Can read/write value
        private List<Transaction> transactions = new List<Transaction>();
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var transaction in transactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        } //remain money in your Ban akcount, Can only read!

        public void Deposit(decimal amount, DateTime date, string note)
        {
            //Money send to Bank account
            if (amount < 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be > 0");
                //Console.WriteLine("Amount must be > 0");
            }

            var deposit = new Transaction(amount, date, note);
            transactions.Add(deposit);
        }

        public void Withdraw(decimal amount, DateTime date, string note) {
            //Eg: widthdraw money to buy a car
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be > 0");
                //Console.WriteLine("Amount must be > 0");
            }

            if (this.Balance - amount < 0)
            {
                throw new InvalidOperationException("No enought money for this trnsaction");
                //Console.WriteLine("No enought money for this trnsaction");
            }
            var withdraw = new Transaction(-amount, date, note);
            transactions.Add(withdraw);
        }

        private long GenerateAccountNumber() {
            return ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();
        }

        public BankAccount(string owner, decimal initialBalance)//function's name = class' name
        {
            this.Owner = owner;
            this.AccountNumber = GenerateAccountNumber();
            //this.Balance = initialBalance;

            Console.WriteLine($"Object initialized with \n" +
                              $"Account Number = {this.AccountNumber} \n" +
                              $"Owner = {this.Owner} \n" +
                              $"Balance = {this.Balance} \n");
        }

    }
}
