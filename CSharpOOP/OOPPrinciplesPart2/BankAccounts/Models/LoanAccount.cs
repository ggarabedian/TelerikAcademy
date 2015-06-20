namespace BankAccounts.Models
{
    using System;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer client, decimal balance, decimal monthlyInterest)
            : base(client, balance, monthlyInterest)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal result = 0.0m;

            if (this.Client is IndividualClient)
            {
                months -= 3;
            }
            else
            {
                months -= 2;
            }

            if (months <= 0)
            {
                return result;
            }

            return months * ((this.MonthlyInterest / 100.0m) * this.Balance);
        }

        public override string ToString()
        {
            return String.Format("Loan Account - Holder: {0} - Balance: {1:C}", this.Client.Name, this.Balance);
        }
    }
}