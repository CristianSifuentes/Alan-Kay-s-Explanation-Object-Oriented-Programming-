public class ChemicalSignal : ICellMessage{
    public string SingnalType { get; }
    public string Message { get; }
    public string GetMessage(){
        return "Chemical signal received";
    }
}