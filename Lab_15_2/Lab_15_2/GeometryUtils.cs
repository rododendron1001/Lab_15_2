using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_2
{
    public static class GeometryUtils
    {

		public static void Translate_X(this Shape shape, int dx)
			
		{
			
			foreach (Point p in shape.Points)
			{
				p.Translate_x(dx);
				
			}
		}

		public static void Translate_Y(this Shape shape, int dy)

		{

			foreach (Point p in shape.Points)
			{
				p.Translate_y(dy);

			}
		}

		public static int Calculate_Perimeter(Shape shape)

        {
            int perimeter = 0;
			
			for (int i = 0; i < shape.Points.Length; i++)
				{

				//length_segment = Math.Abs(Math.Sqrt((P2.X - P1.X) * (P2.X - P1.X) + (P2.Y - P1.Y) * (P2.Y - P1.Y)));
				//perim_triangle=	Math.Abs(Math.Sqrt((P2.X - P1.X) * (P2.X - P1.X) + (P2.Y - P1.Y) * (P2.Y - P1.Y)) + Math.Sqrt((P2.X - P3.X) * (P2.X - P3.X) + (P2.Y - P3.Y) * (P2.Y - P3.Y)) + Math.Sqrt((P3.X - P1.X) * (P3.X - P1.X) + (P3.Y - P1.Y) * (P3.Y - P1.Y)));


				}

			return perimeter;


			


        }

    }  
}
