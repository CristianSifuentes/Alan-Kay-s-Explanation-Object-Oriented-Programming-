public class ImmuneCell : Cell
{
    public ImmuneCell(string name) : base(name, 120) { }

    protected override void ProcessSignal(ICellMessage message)
    {
        if (message is ChemicalSignal signal && signal.SignalType == "Pathogen")
        {
            Console.WriteLine($"[{Name}] Activating immune response due to: {signal.Message}");
            SendSignal(new ChemicalSignal("Response", "Releasing antibodies"));
        }
    }
}