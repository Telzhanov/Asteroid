using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid
{
    class Star:Shape
    {
       
        public Star(int x, int y,Color color, Graphics g)
        {
            this.color = color;
            this.g = g;
            this.x = x;
            this.y = y;
        }
        public void Draw()
        {
                Pen p = new Pen(color);
                RectangleF rectangle = new RectangleF(x, y, 100, 100);
                PointF A = new PointF(rectangle.X, rectangle.Y + rectangle.Height / 2);
                PointF B = new PointF(rectangle.X + rectangle.Width / 2, rectangle.Y);
                PointF C = new PointF(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height / 2);
                PointF[] curvePoints = { A, B, C };
                PointF Z = new PointF(rectangle.X, rectangle.Y + rectangle.Height / 6);
                PointF X = new PointF(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height / 6);
                PointF L = new PointF(rectangle.X + rectangle.Width / 2, rectangle.Y + (rectangle.Height - 30));
                PointF[] curvePoints1 = { Z, X, L };
                g.FillPolygon(p.Brush, curvePoints);
                g.FillPolygon(p.Brush, curvePoints1);
        }
    }
}
