using System.Collections.Generic;

namespace M7Lab.Commands
{
    public class MacroCommand : ICommand
    {
        private List<ICommand> _commands;
        public MacroCommand(List<ICommand> commands) => _commands = commands;

        public void Execute()
        {
            foreach (var cmd in _commands)
                cmd.Execute();
        }

        public void Undo()
        {
            for (int i = _commands.Count - 1; i >= 0; i--)
                _commands[i].Undo();
        }
    }
}
