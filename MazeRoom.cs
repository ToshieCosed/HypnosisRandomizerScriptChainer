using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnosisRandomizer
{
    public class MazeRoom
    {
        public ExitData LocalExits = new ExitData(false, false, false, false);
        public int TileNum { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string MetaData { get; set; }
        public string SessionName { get; set; }
        public bool ran_once { get; set; }

        public MazeRoom()
        {
            TileNum = 0;
            MetaData = "Default";
            SessionName = "";
            ran_once = false;
        }

        public struct ExitData
        {
            public bool NorthExit;
            public bool EastExit;
            public bool SouthExit;
            public bool WestExit;

            public ExitData(bool n, bool e, bool s, bool w)
            {
                NorthExit = n;
                EastExit = e;
                SouthExit = s;
                WestExit = w;
            }
        }

        public void SetAllExits(bool north, bool east, bool south, bool west)
        {
            this.LocalExits.NorthExit = north;
            this.LocalExits.EastExit = east;
            this.LocalExits.SouthExit = south;
            this.LocalExits.WestExit = west;
        }

        public void SetExit(string ExitName, bool state)
        {
            switch (ExitName)
            {
                case "North":
                    this.LocalExits.NorthExit = state;
                    break;
                case "East":
                    this.LocalExits.EastExit = state;
                    break;
                case "South":
                    this.LocalExits.SouthExit = state;
                    break;
                case "West":
                    this.LocalExits.WestExit = state;
                    break;
            }
        }

        public bool CompareDirStruct(ExitData input, ExitData comparable)
        {
            bool result = false;
            if (input.NorthExit == comparable.NorthExit){
                if (input.SouthExit == comparable.SouthExit)
                {
                    if (input.EastExit == comparable.EastExit)
                    {
                        if (input.WestExit == comparable.WestExit)
                        {
                            result = true;
                        }
                    }
                }
                
            }
            return result;
        }


    }
}