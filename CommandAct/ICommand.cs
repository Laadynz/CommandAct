namespace CommandAct
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
