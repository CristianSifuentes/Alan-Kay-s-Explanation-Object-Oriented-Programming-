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
        OnTransaction?.Invoke(new TransactionMessage(AccountHolder, $"Deposited {amount:C}. New balance: {_balance:C}"));
    }

    public void Withdraw(decimal amount)
    {
        if(amount > _balance){
            OnTransaction?.Invoke(new TransactionMessage(AccountHolder, "Insufficient funds!"));

        }else {
           _balance -= amount;
            OnTransaction?.Invoke(new TransactionMessage(AccountHolder, $"Withdrew {amount:C}. New balance: {_balance:C}"));
        }

    }
}