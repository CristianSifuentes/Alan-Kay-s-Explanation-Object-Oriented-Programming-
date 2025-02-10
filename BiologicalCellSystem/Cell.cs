public abstract class Cell {
   public string Name { get; }
   public int Energy { get; protected set;}

   public Cell(string name, int initialEnergy){
       Name = name;
       Energy = initialEnergy;
   }

  // Cells react when they receive chemical signals
   public void ReceiveSignal(ICellMessage message){
         Console.WriteLine(message.GetMessage());
   }

   protected abstract void ProcessSignal(ICellMessage message);

    // Cells can send signals to others
   protected void SendSignal(ICellMessage message){
       // Cells can send signals to others

   }


}