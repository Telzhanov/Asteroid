using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid
{
    class Polygon:Shape
    {
        public Polygon(int x, int y, Color color, Graphics g)
        {
            this.color = color;
            this.g = g;
            this.x = x;
            this.y = y;
        }
        public void Draw()
        {
            Pen p = new Pen(color);
            PointF A = new PointF(x,y);
            PointF B = new PointF(x+50,y+50);
            PointF C = new PointF(x+50,y+125);
            PointF D = new PointF(x, y + 175);
            PointF E = new PointF(x - 50, y + 125);
            PointF F = new PointF(x - 50, y + 50);
            PointF[] curvePoints = { A, B, C,D,E, F};
            g.FillPolygon(p.Brush, curvePoints);
        }
    }
}
