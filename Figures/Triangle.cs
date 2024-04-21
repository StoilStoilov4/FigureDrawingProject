using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawingApp.Figures
{
    public class Triangle : Figure
    {

        public Triangle(int x, int y, int width, int height, Color fillColor, Color outlineColor)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            FillColor = fillColor;
            OutlineColor = outlineColor;
        }

        public override void CalculateArea()
        {
            Area = Width * Height / 2.0;
        }

        public override Figure Clone()
        {
            return new Triangle(X, Y, Width, Height, FillColor, OutlineColor);
        }

        public override bool Contains(PointF point)
        {
            double A = AreaOfTriangle(new PointF(X, Y + Height), new PointF(X + Width / 2, Y), new PointF(X + Width, Y + Height));
            double A1 = AreaOfTriangle(point, new PointF(X, Y + Height), new PointF(X + Width / 2, Y));
            double A2 = AreaOfTriangle(point, new PointF(X + Width / 2, Y), new PointF(X + Width, Y + Height));
            double A3 = AreaOfTriangle(point, new PointF(X, Y + Height), new PointF(X + Width, Y + Height));
            return A == A1 + A2 + A3;
        }

        private double AreaOfTriangle(PointF p1, PointF p2, PointF p3)
        {
            return Math.Abs((p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2.0);
        }

        public override void Draw(Graphics g)
        {
            Point[] points = {
                new Point(X, Y + Height),
                new Point(X + Width / 2, Y),
                new Point(X + Width, Y + Height)
            };
            g.DrawPolygon(new Pen(OutlineColor, 10), points);
        }

        public override void Fill(Graphics g, SolidBrush brush)
        {
            Point[] points = {
                new Point(X, Y + Height),
                new Point(X + Width / 2, Y),
                new Point(X + Width, Y + Height)
            };
            g.FillPolygon(brush, points);
        }
    }
}
