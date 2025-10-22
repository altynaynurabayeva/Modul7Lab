namespace M7Lab.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
