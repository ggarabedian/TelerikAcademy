namespace BankAccounts.Models
{
    using System;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer client, decimal balance, decimal monthlyInterest)
            : base(client, balance, monthlyInterest)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal result = 0.0m;

            if (this.Client is CompanyClient)
            {
                if (months <= 12)
                {
                    result = (months * ((this.MonthlyInterest / 100.0m) * this.Balance)) / 2;
                }
                else
                {
                    result = ((12 * ((this.MonthlyInterest / 100.0m) * this.Balance)) / 2) +
                             ((months - 12) * ((this.MonthlyInterest / 100.0m) * this.Balance));
                }
            }
            else
            {
                if (months <= 6)
                {
                    return result;
                }
                else
                {
                    result = ((months - 6)*(this.MonthlyInterest / 100.0m) * this.Balance);
                }
            }

            return result;
        }

        public override string ToString()
        {
            return String.Format("Mortgage Account - Holder: {0} - Balance: {1:C}", this.Client.Name, this.Balance);
        }
    }
}