using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDrawingApp.Figures;

namespace FigureDrawingApp.Command_Handling
{
    internal class OutlineChangeCommand : ICommand
    {
        private Color _oldColor;
        private Color _newColor;
        private Figure _figure;

        public OutlineChangeCommand(Color newColor, Figure figure)
        {
            _figure = figure;
            _oldColor = figure.OutlineColor;
            _newColor = newColor;
        }

        public void Do()
        {
            _figure.OutlineColor = _newColor;
        }

        public void Undo()
        {
            _figure.OutlineColor = _oldColor;
        }
    }
}
