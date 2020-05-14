using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_2
{
    public class Rectangle : Shape1
    {
        public Rectangle(Point topLeft, int width, int height )
            : base(topLeft, new Point(topLeft.X+width,topLeft.Y), new Point(topLeft.X, topLeft.Y+height), new Point(topLeft.X+width, topLeft.Y+height))
        {
            this.TopLeft = topLeft;
            this.Width = width;
            this.Height = height;
        }
        public Point TopLeft
        {
            get;
        }

        public int Width
        {
            get;
        }

        public int Height
        {
            get;
        }
    }
}
