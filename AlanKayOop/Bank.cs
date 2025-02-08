// Bank acts as a mediator to manage account transactions

public class Bank
{
    private readonly List<BankAccount> _accounts = new();
    internal void RegisterAccount(BankAccount account)
    {
        _accounts.Add(account);
    }
}