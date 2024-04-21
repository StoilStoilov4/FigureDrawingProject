using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDrawingApp.Figures;

namespace FigureDrawingApp.Command_Handling
{
    internal class RemoveFigureCommand : ICommand
    {
        private Figure _figure;
        private List<Figure> _figures;

        public RemoveFigureCommand(List<Figure> figures, Figure figure)
        {
            _figure = figure;
            _figures = figures;
        }

        public void Do()
        {
            _figures.Remove(_figure);
        }

        public void Undo()
        {
            _figures.Add(_figure);
        }
    }
}
