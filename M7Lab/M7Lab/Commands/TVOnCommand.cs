using M7Lab.Devices;

namespace M7Lab.Commands
{
    public class TVOnCommand : ICommand
    {
        private Television _tv;
        public TVOnCommand(Television tv) => _tv = tv;
        public void Execute() => _tv.On();
        public void Undo() => _tv.Off();
    }
}
