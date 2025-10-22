using M7Lab.Devices;

namespace M7Lab.Commands
{
    public class LightOffCommand : ICommand
    {
        private Light _light;
        public LightOffCommand(Light light) => _light = light;
        public void Execute() => _light.Off();
        public void Undo() => _light.On();
    }
}
