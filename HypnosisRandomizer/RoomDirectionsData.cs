using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnosisRandomizer
{
    public class RoomDirectionsData
    {
        public List<MazeRoom> RoomDirections = new List<MazeRoom>();

        public List<MazeRoom> GetData()
        {
            return RoomDirections;
        }

        public void init()
        {
            bool c = false;
            bool o = true;
            MazeRoom no_room = new MazeRoom();
            no_room.TileNum = 0;
            RoomDirections.Add(no_room);
            MazeRoom SealedRoom = new MazeRoom();
            SealedRoom.TileNum = 1;
            RoomDirections.Add(SealedRoom);
            MazeRoom FourWay = new MazeRoom();
            FourWay.SetAllExits(o,o,o,o);
            FourWay.TileNum = 2;
            MazeRoom VerticalHall = new MazeRoom();
            VerticalHall.SetAllExits(o,c,o,c);
            VerticalHall.TileNum = 3;
            RoomDirections.Add(VerticalHall);
            MazeRoom HorizontalHall = new MazeRoom();
            HorizontalHall.TileNum = 4;
            HorizontalHall.SetAllExits(c, o, c, o);
            MazeRoom SealedWest = new MazeRoom();
            SealedWest.SetAllExits(o, o, o, c);
            SealedWest.TileNum = 5;
            RoomDirections.Add(SealedWest);
            MazeRoom SealedEast = new MazeRoom();
            SealedEast.SetAllExits(o, c, o, o);
            SealedEast.TileNum = 6;
            RoomDirections.Add(SealedEast);
            MazeRoom SealedNorth = new MazeRoom();
            SealedNorth.SetAllExits(c,o,o,o);
            SealedNorth.TileNum = 7;
            RoomDirections.Add(SealedNorth);
            MazeRoom SealedSouth = new MazeRoom();
            SealedSouth.SetAllExits(o, o, c, o);
            SealedSouth.TileNum = 8;
            RoomDirections.Add(SealedSouth);
            MazeRoom SouthExit = new MazeRoom();
            SouthExit.SetAllExits(c, c, o, c);
            SouthExit.TileNum = 9;
            RoomDirections.Add(SouthExit);
            MazeRoom NorthExit = new MazeRoom();
            NorthExit.SetAllExits(o, c, c, c);
            NorthExit.TileNum = 10;
            MazeRoom WestExit = new MazeRoom();
            WestExit.SetAllExits(c, c, c, o);
            WestExit.TileNum = 11;
            RoomDirections.Add(WestExit);
            MazeRoom EastExit = new MazeRoom();
            EastExit.SetAllExits(c, o, c, c);
            EastExit.TileNum = 12;
            RoomDirections.Add(EastExit);
        }
    }
}
