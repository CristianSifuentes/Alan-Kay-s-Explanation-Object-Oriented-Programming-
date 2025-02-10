public class Neuron : Cell {
    public Neuron(string name) : base(name, 100){
    }
    protected override void ProcessSignal(ICellMessage message){
        Console.WriteLine("Neuron received signal");
    }
}