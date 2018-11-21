using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnosisRandomizer
{
    public class MazeMap
    {
        public Dictionary<Vector2<int, int>, MazeRoom> rooms = new Dictionary<Vector2<int, int>, MazeRoom>();
        public Vector2<int, int> Finishroom = new Vector2<int, int>(0,0);
        public Vector2<int, int> StartRoom = new Vector2<int, int>(0, 0);

        public MazeRoom GetRoom(Vector2<int, int> RoomLocation)
        {
            MazeRoom defaultroom = new MazeRoom();
            defaultroom.MetaData = "Invalid";
            new object();
            Console.WriteLine("Looking for key at " + RoomLocation.X + ", " + RoomLocation.Y);
            Console.WriteLine(" Result of get Room Key State function is" + getroomkeystate(RoomLocation.X, RoomLocation.Y));
            Console.WriteLine("===Result of GetRoom By Iteration is  " + GetRoomByIteration(RoomLocation.X, RoomLocation.Y).MetaData);



            if (rooms.ContainsKey(new Vector2<int, int>(RoomLocation.X, RoomLocation.Y)))
            {
                Console.WriteLine("Room at " + RoomLocation.X + "," + RoomLocation.Y + " key[" + RoomLocation.X + "," + RoomLocation.Y + "]" + " Session Name is " + rooms[RoomLocation].SessionName);
            }
                if (rooms.ContainsKey(RoomLocation))

            {
                return rooms[RoomLocation];
            } else
            {
                return defaultroom;
            }
        }

        public void SetFinishRoom(int x, int y)
        {
            Finishroom.X = x;
            Finishroom.Y = y;
        }

        public void SetStartRoom(int x, int y)
        {
            StartRoom.X = x;
            StartRoom.Y = y;
        }

        public void AddRoom(Vector2<int, int> RoomLocation, MazeRoom room)
        {
            MazeRoom troom = GetRoomByIteration(RoomLocation.X, RoomLocation.Y);
            if (troom.MetaData == "Invalid")
            {
                rooms.Add(RoomLocation, room);
            }

        }

        public void RemoveRoom(Vector2<int, int> RoomLocation)
        {
            if (rooms.ContainsKey(RoomLocation))
            {
                rooms.Remove(RoomLocation);
            }
        }

        public int CountNeighboors(int x, int y)
        {
            Vector2<int, int> this_room = new Vector2<int, int>(x, y);
            Vector2<int, int> North = new Vector2<int, int>(x, y - 1);
            Vector2<int, int> South = new Vector2<int, int>(x, y + 1);
            Vector2<int, int> East = new Vector2<int, int>(x + 1, y);
            Vector2<int, int> West = new Vector2<int, int>(x - 1, y);

            int neighboor_count = 0;
            if (getroomkeystate(x, y-1)) { neighboor_count += 1; }
            if (getroomkeystate(x, y+1)) { neighboor_count += 1; }
            if (getroomkeystate(x+1, y)) { neighboor_count += 1; }
            if (getroomkeystate(x-1, y)) { neighboor_count += 1; }

            //Console.WriteLine("Coordinates of North are " + North.X + ", " + North.Y);
            //Console.Write("the state of the north neighboor is " + getroomkeystate(x, y-1));
            //rooms.Add(North, new MazeRoom());

            return neighboor_count;
        }

        public bool getroomkeystate(int x, int y)
        {
            bool state = false;
            foreach(KeyValuePair<Vector2<int,int>, MazeRoom> roompair in rooms)
            {
                if (roompair.Key.X == x && roompair.Key.Y == y)
                {
                    state = true;
                    break;
                }
            }
            return state;
        }

        public MazeRoom GetRoomByIteration(int x, int y)
        {
            MazeRoom ReturnRoom = new MazeRoom();
            ReturnRoom.MetaData = "Invalid";
            foreach (KeyValuePair<Vector2<int, int>, MazeRoom> roompair in rooms)
            {
                if (roompair.Key.X == x && roompair.Key.Y == y)
                {
                    ReturnRoom = roompair.Value;
                    ReturnRoom.MetaData = "Not Invalid";
                    break;
                }
            }
            return ReturnRoom;
        }
    }
}
