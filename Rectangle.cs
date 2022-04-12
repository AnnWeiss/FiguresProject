using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresProject
{
    class Rectangle : Figure
    {
        public int width;
        public int height;
        public Rectangle(int X, int Y, int width, int height) : base(X, Y)
        {
            this.width = width;
            this.height = height;
        }
        public override void drawFigure(Bitmap bmp)
        {
            Graphics flagGraphics = Graphics.FromImage(bmp);
            Pen bluePen = new Pen(Color.Blue, 1);
            flagGraphics.DrawRectangle(bluePen, x, y, width, height);
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
