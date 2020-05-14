using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_2
{
    public abstract class Shape1 : Translate_Dx, Translate_Dy
    { 
        public Shape1(params Point[] points)
    {
        this.Points = points ?? new Point[0];
    }

    public Point[] Points
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
