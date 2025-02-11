public class Neuron : Cell
{
    public Neuron(string name) : base(name, 100) { }

    protected override void ProcessSignal(ICellMessage message)
    {
        if (message is ChemicalSignal signal && signal.SignalType == "Neurotransmitter")
        {
            Console.WriteLine($"[{Name}] Firing an action potential due to neurotransmitter: {signal.Message}");
            SendSignal(new ChemicalSignal("Response", "Neural impulse transmitted"));
        }
    }
}