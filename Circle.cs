using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresProject
{
    class Circle : Figure
    {
        public int radius;
        public Circle(int X, int Y, int radius) : base(X, Y)
        {
            this.radius = radius;
        }
        public override void drawFigure(Bitmap bmp)
        {
            Graphics flagGraphics = Graphics.FromImage(bmp);
            Pen bluePen = new Pen(Color.Blue, 1);
            flagGraphics.DrawEllipse(bluePen, x, y, radius*2, radius*2);
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
    }
}
