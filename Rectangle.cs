using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawingApp
{
    internal class Rectangle : Figure
    {

        private readonly PointF[] _points;

        public Rectangle(int startX, int startY, int width, int height, Color fillColor, Color outlineColor)
        {
            X = startX;
            Y = startY;
            this.Width = width;
            this.Height = height;
            FillColor = fillColor;
            OutlineColor = outlineColor;
            _points = new PointF[] 
                {
                new PointF(X, Y),
                new PointF(X + width, Y),
                new PointF(X + width, Y + height),
                new PointF(X, Y + height)
                };
        }


        public override void CalculateArea()
        {
            //convert to cm^2
            Area =  (Width * Height);
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(OutlineColor, 10))
            {
                g.DrawRectangle(pen, X, Y, Width, Height);
            }
        }

        public override void Fill(Graphics g, SolidBrush brush)
        {
            if (IsFilled)
            {
                brush.Color = FillColor;
                g.FillRectangle(brush, X, Y, Width, Height);
            }
        }

        public override bool Contains(PointF point)
        {
            return point.X >= X && point.X <= X + Width && point.Y >= Y && point.Y <= Y + Height;
        }

        public override Figure Clone()
        {
            return new Rectangle(X, Y, Width, Height, FillColor, OutlineColor);
        }

    }
}
