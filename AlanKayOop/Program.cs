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
   
    }
}