using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid
{
    class Bullet:Shape
    {
        public Bullet (int x, int y, Color color, Graphics g)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.g = g;
        }
        public void Draw()
        {
            Pen p = new Pen(color);
            RectangleF rectangle = new RectangleF(x, y, 50, 50);
            PointF A = new PointF(rectangle.X, rectangle.Y + rectangle.Height / 2);
            PointF B = new PointF(rectangle.X + rectangle.Width / 2, rectangle.Y+(rectangle.Height-40));
            PointF C = new PointF(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height / 2);
            PointF D = new PointF(rectangle.X + rectangle.Width / 2, rectangle.Y + (rectangle.Height - 10));
            PointF[] curvePoints = { A, B, C,D };
            PointF F = new PointF(rectangle.X + rectangle.Width / 2,rectangle.Y );
            PointF G = new PointF( rectangle.X + (rectangle.Width - 40),rectangle.Y + rectangle.Height / 2);
            PointF H = new PointF(rectangle.X + rectangle.Width / 2,rectangle.Y + rectangle.Height );
            PointF J = new PointF(rectangle.X + (rectangle.Width - 10),rectangle.Y + rectangle.Height / 2 );
            PointF[] curvePoints1 = { F, G, H, J };
            g.FillPolygon(p.Brush, curvePoints);
            g.FillPolygon(p.Brush, curvePoints1);
        }
    }
}
