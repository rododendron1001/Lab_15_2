using System;

namespace Lab_15_2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public struct Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Translate_x(int dx)
        {
            this.X += dx;         
        }

        public void Translate_y(int dy)
        {
            this.Y += dy;
        }

    }
}