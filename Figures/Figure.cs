using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawingApp.Figures
{
    //made figure public abstract instead of abstract in order to be accessible in the AppState clone
    [Serializable]
    public abstract class Figure
    {
        public Figure() { }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsFilled { get; set; }
        public Color FillColor { get; set; }
        public Color OutlineColor { get; set; }

        public double Area { get; set; }

        public abstract void CalculateArea();

        public abstract void Draw(Graphics g);

        public abstract void Fill(Graphics g, SolidBrush brush);

        public virtual void SetPosition(int x, int y)
        {
            X = x - Width / 2;
            Y = y - Height / 2;
        }

        public abstract bool Contains(PointF point);


        public abstract Figure Clone();

    }
}
