using M7Lab.Devices;

namespace M7Lab.Commands
{
    public class LightOnCommand : ICommand
    {
        private Light _light;
        public LightOnCommand(Light light) => _light = light;
        public void Execute() => _light.On();
        public void Undo() => _light.Off();
    }
}
