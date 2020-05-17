using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_2
{
    public class Segment_I : Shape
    {
        public Point[] Points
        {
            get;
        }

        public Segment_I(Point p1, Point p2)
       
        {
            this.P1 = p1;
            this.P2 = p2;

        }

        public Point P1
        {
            get;
        }

        public Point P2
        {
            get;
        }

        public void Points_Array(params Point[] points)
        {
            return ;
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
