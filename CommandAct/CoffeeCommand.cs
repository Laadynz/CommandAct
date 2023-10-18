namespace CommandAct
{
    public class CoffeeCommand : ICommand
    {
        private Cafe cafe;
        public CoffeeCommand(Cafe cafe)
        {
            this.cafe = cafe;
        }

        public void Execute()
        {
            cafe.MakeCoffee();
        }

        public void Undo()
        {
            cafe.CancelCoffee();
        }
    }
}
