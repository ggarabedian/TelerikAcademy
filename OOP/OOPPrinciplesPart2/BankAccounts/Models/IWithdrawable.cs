namespace BankAccounts.Models
{
    public interface IWithdrawable
    {
        void WithdrawMoney(decimal amount);
    }
}
