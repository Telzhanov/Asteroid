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
            this.Width = 1000;
            this.Height = 700;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush2 = new SolidBrush(Color.White);
            SolidBrush solidBrush5 = new SolidBrush(Color.Green);
            e.Graphics.FillRectangle(new SolidBrush(Color.DodgerBlue), 0, 0, 1000, 700);
            e.Graphics.FillEllipse(solidBrush2, 15, 15, 30, 30);
            e.Graphics.FillEllipse(solidBrush2, 550, 100, 30, 30);
            e.Graphics.FillEllipse(solidBrush2, 300, 15, 30, 30);
            e.Graphics.FillEllipse(solidBrush2, 900, 200, 30, 30);
            e.Graphics.FillEllipse(solidBrush2, 15, 600, 30, 30);
            e.Graphics.FillEllipse(solidBrush2, 300, 500, 30, 30);
            e.Graphics.FillEllipse(solidBrush2, 900, 600, 30, 30);   
            Graphics g = e.Graphics;
            Star str = new Star(100,150, Color.Red, e.Graphics);
            str.Draw();
            Star str1 = new Star(700, 150, Color.Red, e.Graphics);
            str1.Draw();
            Star str2 = new Star(150, 400, Color.Red, e.Graphics);
            str2.Draw();
            Star str3 = new Star(750, 400, Color.Red, e.Graphics);
            str3.Draw();
            Polygon plg = new Polygon(500, 200, Color.Yellow, e.Graphics);
            plg.Draw();
            Point point31 = new Point(500, 250);
            Point point32 = new Point(515, 270);
            Point point33 = new Point(485, 270);
            Point[] corvePoints5 = { point31, point32, point33 };
            e.Graphics.FillPolygon(solidBrush5, corvePoints5);
            e.Graphics.FillRectangle(solidBrush5, 493, 270, 15, 30);
            Bullet blt = new Bullet(500, 150, Color.Green, e.Graphics);
            blt.Draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

