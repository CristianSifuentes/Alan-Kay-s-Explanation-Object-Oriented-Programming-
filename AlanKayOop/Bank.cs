// Bank acts as a mediator to manage account transactions

public class Bank
{
    private readonly List<BankAccount> _accounts = new();
    public void RegisterAccount(BankAccount account){
        account.OnTransaction += HandleTransaction;
        _accounts.Add(account);
    }
    private void HandleTransaction(IMessage message){
        Console.WriteLine(message.GetMessage());

    }
}