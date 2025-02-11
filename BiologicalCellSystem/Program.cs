class Program
{
    static void Main()
    {
        Neuron neuron = new Neuron("Neuron A");
        ImmuneCell immuneCell = new ImmuneCell("Immune B");

        // Cells listen to each other's signals
        neuron.OnSignalReceived += immuneCell.ReceiveSignal;
        immuneCell.OnSignalReceived += neuron.ReceiveSignal;

        // Simulate sending signals
        neuron.ReceiveSignal(new ChemicalSignal("Neurotransmitter", "Dopamine released"));
        immuneCell.ReceiveSignal(new ChemicalSignal("Pathogen", "Virus detected"));
    }
}