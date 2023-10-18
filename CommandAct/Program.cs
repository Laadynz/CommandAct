using CommandAct;

class Program
{
    static void Main(string[] args)
    {
        Cafe cafe = new Cafe();

        ICommand coffeeCommand = new CoffeeCommand(cafe);
        ICommand teaCommand = new TeaCommand(cafe);
        ICommand undoCommand = new UndoCommand(cafe);

        coffeeCommand.Execute();
        teaCommand.Execute();
        undoCommand.Execute();

        Console.ReadKey();
    }
}
