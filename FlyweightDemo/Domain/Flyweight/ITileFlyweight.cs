using System.Drawing;

namespace FlyweightDemo
{
    public interface ITileFlyweight
    {
        void Draw(Graphics g, int x, int y, int width, int height);
    }
}
