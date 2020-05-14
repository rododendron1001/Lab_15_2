using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_2
{
    public class Segment : Shape1
    {
		public Segment(Point p1, Point p2)
		: base(p1, p2)
		{
			this.P1 = p1 ;
			this.P2 = p2 ;
			
		}

		public Point P1
		{
			get;
		}

		public Point P2
		{
			get;
		}

		
	}
}
