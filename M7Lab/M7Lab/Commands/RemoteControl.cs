namespace M7Lab.Commands
{
    public class RemoteControl
    {
        private ICommand _onCommand;
        private ICommand _offCommand;
        private ICommand _undoCommand;

        public void SetCommands(ICommand onCommand, ICommand offCommand)
        {
            _onCommand = onCommand;
            _offCommand = offCommand;
        }

        public void PressOnButton()
        {
            _onCommand.Execute();
            _undoCommand = _onCommand;
        }

        public void PressOffButton()
        {
            _offCommand.Execute();
            _undoCommand = _offCommand;
        }

        public void PressUndoButton() => _undoCommand?.Undo();
    }
}
