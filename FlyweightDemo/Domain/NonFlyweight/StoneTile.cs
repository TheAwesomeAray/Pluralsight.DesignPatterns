using System.Drawing;

namespace FlyweightDemo
{
    public class StoneTile : ITile
    {
        public static int ObjectCounter = 0;

        Brush paintBrush;

        public int Height { get; set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public StoneTile(int x, int y, int width, int height)
        {
            paintBrush = Brushes.Blue;
            X = x;
            Y = y;
            Width = width;
            Height = height;

            ++ObjectCounter;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(paintBrush, X, Y, Width, Height);
        }
    }
}
