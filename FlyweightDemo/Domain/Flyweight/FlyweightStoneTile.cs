using System.Drawing;

namespace FlyweightDemo
{
    class FlyweightStoneTile : ITileFlyweight
    {
        public static int ObjectCounter = 0;

        Brush paintBrush;

        public FlyweightStoneTile()
        {
            paintBrush = Brushes.Blue;
            ++ObjectCounter;
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }
}
