using FlyweightDemo.Domain;
using System;
using System.Windows.Forms;

namespace FlyweightDemo
{
    public partial class TileDemo : Form
    {
        Random random = new Random();

        public TileDemo()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ITileFlyweight ceramicTile = TileFactory.GetTile("Ceramic");
            for (int i = 0; i < 20; i++)
            {
                ceramicTile.Draw(e.Graphics, GetRandomNumber(), GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
            }

            ITileFlyweight stoneTile = TileFactory.GetTile("Stone");
            for (int i = 0; i < 20; i++)
            {
                stoneTile.Draw(e.Graphics, GetRandomNumber(), GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
            }

            this.label1.Text = $"{FlyweightCeramicTile.ObjectCounter + FlyweightStoneTile.ObjectCounter}";
        }

        private int GetRandomNumber()
        {
            return random.Next(100);
        }
    }
}
