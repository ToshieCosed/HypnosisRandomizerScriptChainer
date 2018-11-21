using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnosisRandomizer
{
    public class TileMap
    {
        public TileGraphic[,] map { get; set; }
        public String[,] scriptnamesMap { get; set; }
        public int width = 0;
        public int height = 0;

        public TileMap(Vector2<int, int> size)
        {
            width = size.X;
            height = size.Y;
            TileGraphic[,] map = new TileGraphic[width, height];
        }
    }
}
