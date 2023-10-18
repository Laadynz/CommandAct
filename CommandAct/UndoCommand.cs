namespace CommandAct
{
    public class UndoCommand : ICommand
    {
        private Cafe cafe;
        public UndoCommand(Cafe cafe)
        {
            this.cafe = cafe;
        }
        public void Execute()
        {
            cafe.UndoLastOrder();
        }

        public void Undo()
        {
            //throw new NotImplementedException();
        }
    }
}
