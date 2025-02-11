// A chemical signal class used for intercellular communication
public class ChemicalSignal : ICellMessage
{
    public string SignalType { get; }
    public string Message { get; }

    public ChemicalSignal(string type, string message)
    {
        SignalType = type;
        Message = message;
    }

    public string GetMessage() => $"Signal: {SignalType}, Message: {Message}";
}