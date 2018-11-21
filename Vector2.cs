using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnosisRandomizer
{
    public class Vector2<Tx, Ty>
    {
        public Tx X { get; set; }
        public Ty Y { get; set; }

        public Vector2(Tx nx, Ty ny)
        {
            this.X = nx;
            this.Y = ny;
        }

    }
}
