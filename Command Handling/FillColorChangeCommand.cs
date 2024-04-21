using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDrawingApp.Figures;

namespace FigureDrawingApp.Command_Handling
{
    internal class FillColorChangeCommand : ICommand
    {
        private Color _oldColor;
        private Color _newColor;
        private Figure _figure;

        public FillColorChangeCommand(Color newColor, Figure figure)
        {
            _figure = figure;
            _oldColor = figure.FillColor;
            _newColor = newColor;
        }

        public void Do()
        {
            _figure.FillColor = _newColor;
        }

        public void Undo()
        {
            _figure.FillColor = _oldColor;
        }
    }
}
