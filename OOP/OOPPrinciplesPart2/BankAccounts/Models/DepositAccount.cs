namespace BankAccounts.Models
{
    using System;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer client, decimal balance, decimal monthlyInterest)
            : base(client, balance, monthlyInterest)
        {
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Amount to withdraw must be less than current account balance");
            }

            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            decimal result = 0.0m;

            if (this.Balance < 1000.0m)
            {
                return result;
            }

            return months * ((this.MonthlyInterest / 100.0m) * this.Balance);
        }

        public override string ToString()
        {
            return String.Format("Deposit Account - Holder: {0} - Balance: {1:C}", this.Client.Name, this.Balance);
        }
    }
}
