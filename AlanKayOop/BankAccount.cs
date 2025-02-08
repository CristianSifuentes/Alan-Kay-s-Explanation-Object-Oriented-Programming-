// Event-based banking system using Alan Kay's vision of OOP
public class BankAccount
{
    public string AccountHolder;
    private decimal _balance;


    public BankAccount(string holder, decimal initialBalance)
    {
        AccountHolder = holder;
        _balance = initialBalance;
    }
}