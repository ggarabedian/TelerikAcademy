namespace BankAccounts.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Bank
    {
        private IList<Account> accounts;

        public Bank()
        {
            this.accounts = new List<Account>();
        }

        public Account this[int index]
        {
            get
            {
                return this.accounts[index];
            }
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            this.accounts.Remove(account);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var acc in accounts)
            {
                result.AppendLine(acc.ToString());
            }

            return result.ToString();
        }
    }
}
