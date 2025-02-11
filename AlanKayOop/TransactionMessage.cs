// Custom transaction message
public class TransactionMessage : IMessage
{
    private readonly string _accountHolder;
    private readonly string _message;

    public TransactionMessage(string accountHolder, string message)
    {
        _accountHolder = accountHolder;
        _message = message;
    }

    public string GetMessage() => $"[{_accountHolder}] {_message}";

}