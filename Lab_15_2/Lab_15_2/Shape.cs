using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_2
{
    public interface Shape: Translate_Dx, Translate_Dy
    {

        void Points_Array(params Point[] points);

        public Point[] Points
        {
            get;
        }

    }
}
