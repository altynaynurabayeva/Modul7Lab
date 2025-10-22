using M7Lab.Devices;

namespace M7Lab.Commands
{
    public class TVOffCommand : ICommand
    {
        private Television _tv;
        public TVOffCommand(Television tv) => _tv = tv;
        public void Execute() => _tv.Off();
        public void Undo() => _tv.On();
    }
}
