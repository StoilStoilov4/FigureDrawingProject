using FigureDrawingApp.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawingApp.Command_Handling
{
    public class ResizeFigureCommand : ICommand
    {
        private int _oldWidth;
        private int _oldHeight;
        private int _newWidth;
        private int _newHeight;
        private readonly Figure _figure;

        public ResizeFigureCommand(Figure figure, int newWidth, int newHeight)
        {
            _figure = figure;
            _newWidth = newWidth;
            _newHeight = newHeight;
            _oldWidth = figure.Width;
            _oldHeight = figure.Height;
        }

        public void Do()
        {
            _figure.Width = _newWidth;
            _figure.Height = _newHeight;
        }

        public void Undo()
        {
            _figure.Width = _oldWidth;
            _figure.Height = _oldHeight;
        }
    }
}
