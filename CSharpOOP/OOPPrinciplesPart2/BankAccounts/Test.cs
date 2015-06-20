namespace BankAccounts
{
    using System;
    using System.Collections.Generic;

    using Models;

    public class Test
    {
        static void Main()
        {
            var ccb = new Bank();

            var george = new IndividualClient("George");
            var james = new IndividualClient("James");
            var sunLtd = new CompanyClient("Sun Ltd");
            var moonLtd = new CompanyClient("Moon Ltd");

            var georgeAccount = new DepositAccount(george, 5000.0m, 5);
            var jamesAccount = new LoanAccount(james, 15000.0m, 7);
            var sunLtdAccount = new LoanAccount(sunLtd, 25000.0m, 10);
            var moonLtdAccount = new MortgageAccount(moonLtd, 50000.0m, 12);

            ccb.AddAccount(georgeAccount);
            ccb.AddAccount(jamesAccount);
            ccb.AddAccount(sunLtdAccount);
            ccb.AddAccount(moonLtdAccount);

            Console.Write(ccb);

            Console.WriteLine(new string('*', 60));

            Console.WriteLine("George monthly interest calculated: {0:F2}", georgeAccount.CalculateInterest(6));
            Console.WriteLine("Sun Ltd monthly interest calculated: {0:F2}", sunLtdAccount.CalculateInterest(12));

            Console.WriteLine(new string('*', 60));

            georgeAccount.WithdrawMoney(2500.0m);
            jamesAccount.DepositMoney(1500.0m);
            moonLtdAccount.DepositMoney(12500.0m);

            Console.Write(ccb);
        }
    }
}
