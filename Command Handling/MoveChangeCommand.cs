using FigureDrawingApp.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawingApp.Command_Handling
{
    internal class MoveChangeCommand : ICommand
    {
        private int _oldX;
        private int _oldY;
        private int _newX;
        private int _newY;
        private Figure? _figure;

        public MoveChangeCommand(int oldX, int oldY, Figure figure)
        {
              _figure = figure;
              _newX = figure.X;
              _newY = figure.Y;
              _oldX = oldX;
              _oldY = oldY;

        }

        public void Do()
        {
            _figure.X = _newX;
            _figure.Y = _newY;
        }

        public void Undo()
        {
            _figure.X = _oldX;
            _figure.Y = _oldY;
        }
    }
}
