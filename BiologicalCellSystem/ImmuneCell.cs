public class ImmuneCell : Cell {
    public ImmuneCell(string name) : base(name, 100){
    }
    protected override void ProcessSignal(ICellMessage message){
        Console.WriteLine("Immune cell received signal");
    }
}