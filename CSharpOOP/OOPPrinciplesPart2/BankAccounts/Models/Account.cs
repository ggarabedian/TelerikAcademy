namespace BankAccounts.Models
{
    using System;

    public abstract class Account : IDepositable
    {
        private Customer client;
        private decimal balance;
        private decimal monthlyInterest;

        public Account(Customer client, decimal balance, decimal monthlyInterest)
        {
            this.Client = client;
            this.Balance = balance;
            this.MonthlyInterest = monthlyInterest;
        }

#region Properties

        public Customer Client { get; set; }

        public decimal Balance { get; set; }

        public decimal MonthlyInterest { get; private set; }

#endregion    

        public void DepositMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount deposited must be greater than 0");
            }

            this.Balance += amount;
        }

        public abstract decimal CalculateInterest(int months);
    }
}
