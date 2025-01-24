using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class CommandManager
    {
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();
        private Stack<ICommand> _redoStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand lastCommand = _commandHistory.Pop();
                lastCommand.Undo();
                _redoStack.Push(lastCommand);
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                ICommand lastUndoneCommand = _redoStack.Pop();
                lastUndoneCommand.Execute();
                _commandHistory.Push(lastUndoneCommand);
            }
        }
    }
}