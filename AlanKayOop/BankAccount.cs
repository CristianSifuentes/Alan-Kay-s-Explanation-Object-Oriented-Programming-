// Event-based banking system using Alan Kay's vision of OOP

public class BankAccount
{
    public string AccountHolder;
    private decimal _balance;
    public event Action<IMessage> OnTransaction;


    public BankAccount(string holder, decimal initialBalance)
    {
        AccountHolder = holder;
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    internal void Withdraw(decimal amount)
    {
        _balance -= amount;
    }
}