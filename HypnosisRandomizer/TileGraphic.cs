using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnosisRandomizer
{
    public class TileGraphic
    {
        public Bitmap localtile { get; set; }
        public string name { get; set; }
        public Vector2<int, int> location { get; set; }
        public int TileType { get; set; }

        public TileGraphic()
        {
            Bitmap b = new Bitmap(32, 32);
            localtile = b;
            name = "default";

        }
            
    }
}