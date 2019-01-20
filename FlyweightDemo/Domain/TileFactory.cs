using System.Collections.Generic;

namespace FlyweightDemo.Domain
{
    public class TileFactory
    {
        static Dictionary<string, ITileFlyweight> tiles = new Dictionary<string, ITileFlyweight>();

        public static ITileFlyweight GetTile(string tileType)
        {
            switch (tileType)
            {
                case "Ceramic":
                    if (!tiles.ContainsKey("Ceramic"))
                        tiles["Ceramic"] = new FlyweightCeramicTile();
                    return tiles["Ceramic"];
                case "Stone":
                    if (!tiles.ContainsKey("Stone"))
                        tiles["Stone"] = new FlyweightStoneTile();
                    return tiles["Stone"];
                default:
                    break;
            }

            return new NullTile();
        }
    }
}
