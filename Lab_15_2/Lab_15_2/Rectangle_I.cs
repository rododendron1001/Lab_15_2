using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_2
{
    public class Rectangle_I : Shape
    {
        public Point[] Points
        {
            get
             {
                return new Point[] { TopLeft, new Point(TopLeft.X + Width, TopLeft.Y), new Point(TopLeft.X, TopLeft.Y + Height), new Point(TopLeft.X + Width, TopLeft.Y + Height) };
            }
        }

        public Rectangle_I(Point topLeft, int width, int height)
           
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

        void Translate_Dy.Translate_Y(int dy)
        {

            foreach (Point p in this.Points)
            {
                p.Translate_y(dy);
            }
        }

        void Translate_Dx.Translate_X(int dx)
        {

            foreach (Point p in this.Points)
            {
                p.Translate_x(dx);
               
            }
        }
    }
}
