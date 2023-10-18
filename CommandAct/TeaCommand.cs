namespace CommandAct
{
    public class TeaCommand : ICommand
    {
        private Cafe cafe;
        public TeaCommand(Cafe cafe)
        {
            this.cafe = cafe;
        }
        public void Execute()
        {
            cafe.MakeTea();
        }

        public void Undo()
        {
            cafe.CancelTea();
        }
    }
}
