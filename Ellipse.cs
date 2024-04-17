using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawingApp
{
    internal class Ellipse : Figure
    {
        public Ellipse(int x, int y, int width, int height, Color fillColor, Color outlineColor)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            FillColor = fillColor;
            OutlineColor = outlineColor;
        }
        public Ellipse()
        {

        }
        public override void CalculateArea()
        {
            //PI * r^2 = Area
            Area = (Math.PI * (Width / 2.0) * (Height / 2.0));
        }

        public override bool Contains(PointF point)
        {
            float a = Width / 2.0f;
            float b = Height / 2.0f;
            float dx = point.X - (X + a);
            float dy = point.Y - (Y + b);
            return (dx * dx) / (a * a) + (dy * dy) / (b * b) <= 1;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(OutlineColor, 10))
            {
                g.DrawEllipse(pen, X, Y, Width, Height);
            }
        }

        public override void Fill(Graphics g, SolidBrush brush)
        {
            if (IsFilled)
            {
                brush.Color = FillColor;
                g.FillEllipse(brush, X, Y, Width, Height);
            }
        }

        public override Figure Clone()
        {
            return new Ellipse(X, Y, Width, Height, FillColor, OutlineColor);
        }
    }
}
