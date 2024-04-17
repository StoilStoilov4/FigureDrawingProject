using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawingApp
{
    public class AppState
    {
        public List<Figure> Figures { get; set; }
        public Color FillColor { get; set; }
        public Color OutlineColor { get; set; }

    }
}
