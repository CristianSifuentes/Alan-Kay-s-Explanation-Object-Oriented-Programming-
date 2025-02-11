public abstract class Cell
{
    public string Name { get; }
    public int Energy { get; protected set; }
    public event Action<ICellMessage>? OnSignalReceived;

    public Cell(string name, int initialEnergy)
    {
        Name = name;
        Energy = initialEnergy;
    }

    // Cells react when they receive chemical signals
    public void ReceiveSignal(ICellMessage message)
    {
        Console.WriteLine($"[{Name}] Received: {message.GetMessage()}");
        ProcessSignal(message);
    }

    protected abstract void ProcessSignal(ICellMessage message);

    // Cells can send signals to others
    protected void SendSignal(ICellMessage message)
    {
        OnSignalReceived?.Invoke(message);
    }
}