using System.Drawing;

namespace FlyweightDemo
{
    class FlyweightCeramicTile : ITileFlyweight
    {
        public static int ObjectCounter = 0;

        Brush paintBrush;

        public FlyweightCeramicTile()
        {
            paintBrush = Brushes.Red;
            ++ObjectCounter;
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }
}
