using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_2
{
    public class Triangle : Shape1
    {
		public Triangle(Point p1, Point p2, Point p3)
		: base(p1, p2, p3)
		{
			this.P1 = p1 ;
			this.P2 = p2 ;
			this.P3 = p3 ;
		}

		public Point P1
		{
			get;
		}

		public Point P2
		{
			get;
		}

		public Point P3
		{
			get;
		}
	}
}
