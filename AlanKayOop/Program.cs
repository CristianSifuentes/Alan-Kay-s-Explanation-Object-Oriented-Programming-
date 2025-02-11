// Main program to demonstrate the system
class Program
{
    static void Main()
    {  
        Bank bank = new Bank();
        
        var account1 = new BankAccount("Alice", 1000);
        var account2 = new BankAccount("Bob", 500);

        bank.RegisterAccount(account1);
        bank.RegisterAccount(account2);

        account1.Deposit(200);
        account1.Withdraw(500);
        account2.Withdraw(700);
        account2.Deposit(1000);
   
    }
}