using System.Drawing;

namespace FlyweightDemo
{
    class NullTile : ITileFlyweight
    {
        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            
        }
    }
}
