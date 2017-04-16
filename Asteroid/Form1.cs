using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 515;
            this.Height = 538;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            SolidBrush solidBrush1 = new SolidBrush(Color.DodgerBlue);
            SolidBrush solidBrush2 = new SolidBrush(Color.White);
            SolidBrush solidBrush3 = new SolidBrush(Color.Red);
            SolidBrush solidBrush4 = new SolidBrush(Color.Yellow);
            SolidBrush solidBrush5 = new SolidBrush(Color.Green);
            e.Graphics.FillRectangle(solidBrush, 0, 0, 500, 500);
            e.Graphics.FillRectangle(solidBrush1, 5, 5, 490, 490);
            e.Graphics.FillEllipse(solidBrush2, 15, 15, 30, 30);
            e.Graphics.FillEllipse(solidBrush2, 50, 100, 30, 30);
            e.Graphics.FillEllipse(solidBrush2, 300, 15, 30, 30);
            Point point1 = new Point(160, 140);
            Point point2 = new Point(180, 110);
            Point point3 = new Point(200, 140);
            Point point4 = new Point(160, 120);
            Point point5 = new Point(200, 120);
            Point point6 = new Point(180, 150);
            Point point11 = new Point(360, 300);
            Point point12 = new Point(380, 270);
            Point point13 = new Point(400, 300);
            Point point14 = new Point(360, 280);
            Point point15 = new Point(400, 280);
            Point point16 = new Point(380, 310);
            Point point21 = new Point(200, 210);
            Point point22 = new Point(240, 190);
            Point point23 = new Point(280, 210);
            Point point24 = new Point(280, 240);
            Point point25 = new Point(240, 260);
            Point point26 = new Point(200, 240);
            Point point31 = new Point(240, 200);
            Point point32 = new Point(255, 220);
            Point point33 = new Point(225, 220);
            Point[] curvePoints = { point1, point2, point3
                                 };
            Point[] corvePoints1 = { point4, point5, point6 };
            Point[] corvePoints2 = { point11, point12, point13 };
            Point[] corvePoints3 = { point14, point15, point16 };
            Point[] corvePoints4 = { point21, point22, point23, point24, point25, point26 };
            Point[] corvePoints5 = { point31, point32, point33 };
            e.Graphics.FillPolygon(solidBrush3, curvePoints);
            e.Graphics.FillPolygon(solidBrush3, corvePoints1);
            e.Graphics.FillPolygon(solidBrush3, corvePoints2);
            e.Graphics.FillPolygon(solidBrush3, corvePoints3);
            e.Graphics.FillPolygon(solidBrush4, corvePoints4);
            e.Graphics.FillPolygon(solidBrush5, corvePoints5);
            e.Graphics.FillRectangle(solidBrush5, 233, 220, 15, 20);
        }

    }
}

