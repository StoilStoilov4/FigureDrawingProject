using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawingApp
{
    public class CommandController
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        private int _commandIndex = -1;

        public void AddCommand(ICommand command)
        {
            if (_commandIndex < _commands.Count - 1)
            {
                _commands.RemoveRange(_commandIndex + 1, _commands.Count - _commandIndex - 1);
            }
    
            command.Do();
            _commands.Add(command);
            _commandIndex = _commands.Count - 1;
        }

        public void Do()
        {
            if (_commandIndex < _commands.Count - 1)
            {
                _commandIndex++;
                _commands[_commandIndex].Do();
            }
            
        }

        public void Undo()
        {
            if (_commandIndex >= 0)
            {
                _commands[_commandIndex].Undo();
                _commandIndex--;
            }

        }
    }
}
