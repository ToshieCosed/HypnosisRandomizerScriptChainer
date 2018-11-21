    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace HypnosisRandomizer
{
    public partial class MapForm : Form
    {
        public List<TileGraphic> tiles_list = new List<TileGraphic>();
        public List<TileGraphic> PalletizedTiles = new List<TileGraphic>();
        public TileMap tmap;
        public MazeMap mazemap = new MazeMap();
        public RoomDirectionsData TileDirData = new RoomDirectionsData();
        public bool done_generating = false;
        public List<Vector2<int, int>> coords_ = new List<Vector2<int, int>>();
        public Player player = new Player();
        public bool FirstRun = true;
        public MapForm()
        {
            InitializeComponent();
        }

        //Map form Load Class taken from StackOverFlow
        // here: https://stackoverflow.com/questions/23786295/basic-tile-map-in-winforms
        private void MapFormLoad(object sender, EventArgs e)
        {
            int tileWidth = 64;
            int tileHeight = 64;
            int tileRows = 15;
            int tileCols = 15;


            using (Bitmap sourceBmp = new Bitmap("roomicons.png"))
            {
                Size s = new Size(tileWidth, tileHeight);
                Rectangle destRect = new Rectangle(Point.Empty, s);
                int tempindex = 0;
                for (int row = 0; row < tileRows; row++)
                    for (int col = 0; col < tileCols; col++)
                    {
                        PictureBox p = new PictureBox();
                        p.Size = s;
                        p.SizeMode = PictureBoxSizeMode.CenterImage;
                        Point loc = new Point((tileWidth * col) + ((col * 2) - 1), (tileHeight * row) + ((row * 2) - 1));
                        //Rectangle srcRect = new Rectangle(loc, s);
                        //Bitmap tile = new Bitmap(tileWidth, tileHeight);
                        // Graphics G = Graphics.FromImage(tile);
                        // G.DrawImage(sourceBmp, destRect, srcRect, GraphicsUnit.Pixel);

                        //tempindex++;
                        //if (tempindex > tiles_list.Count - 1) { tempindex = tiles_list.Count - 1; }
                        // Bitmap temp_bmp = tiles_list.ToArray()[tempindex].localtile;
                        Bitmap temp_bmp = tiles_list.ToArray()[0].localtile;

                        p.Image = temp_bmp;
                        p.Location = loc;
                        p.Tag = loc;
                        p.Name = col + "," + row;
                        p.Click += this.onclick_;
                        TileGraphic tempgraphic = new TileGraphic();
                        tempgraphic.localtile = temp_bmp;
                        tmap.map[col, row] = tempgraphic;
                        tmap.map[col, row].name = new string(String.Format(col + "," + row).ToCharArray());
                        tmap.map[col, row].TileType = 0;

                        // p.MouseDown += p_MouseDown;
                        // p.MouseUp += p_MouseUp;
                        // p.MouseMove += p_MouseMove;
                        this.Controls.Add(p);
                    }
            }

            //MapForm_Load(sender, e);

        }

        public void onclick_(object sender, EventArgs e)
        {
            PictureBox m = (PictureBox)sender;
            string coords = m.Name;
            string[] splits = coords.Split(',');
            int pbx = Convert.ToInt32(splits[0]);
            int pby = Convert.ToInt32(splits[1]);
            // Console.WriteLine("This picture box location is " + pbx + ", " + pby);
            //Console.WriteLine("This picturebox type is " + tmap.map[pbx, pby].TileType);
            int tiletype = tmap.map[pbx, pby].TileType + 1;
            if (tiletype > 13) { tiletype = 0; }
            tmap.map[pbx, pby].TileType = tiletype;
            Vector2<int, int> RoomLoc = new Vector2<int, int>(pbx, pby);
            bool North = mazemap.getroomkeystate(pbx, pby - 1);
            bool East = mazemap.getroomkeystate(pbx+1, pby);
            bool South = mazemap.getroomkeystate(pbx, pby+1);
            bool West = mazemap.getroomkeystate(pbx-1, pby);


            //Console.WriteLine("Neighboor count is " + mazemap.CountNeighboors(pbx, pby));
            //Console.WriteLine("The x and Y is " + pbx + ", " + pby);
            //Console.WriteLine("The exits are: North->" + North + "| South->" + South + "| East->" + East + "| West->" + West);
            //MazeRoom troom = mazemap.GetRoomByIteration(pbx, pby);
            //Console.WriteLine("The filename here is " + troom.SessionName);
            
        }

        public void Player_Move()
        {
            QueryMulti Select = new QueryMulti();
            int pbx = player.X;
            int pby = player.Y;

            int oldx = player.X;
            int oldy = player.Y;
            //Get Neighboor states.
            bool North = mazemap.getroomkeystate(pbx, pby - 1);
            bool East = mazemap.getroomkeystate(pbx + 1, pby);
            bool South = mazemap.getroomkeystate(pbx, pby + 1);
            bool West = mazemap.getroomkeystate(pbx - 1, pby);

                //Setup Buttons
            if (North) { Select.One.Text = "Move North"; }else
            { Select.One.Hide(); }
            if (East) { Select.Two.Text = "Move East"; }else
            { Select.Two.Hide(); }
            if (South) { Select.Three.Text = "Move South"; }else
            { Select.Three.Hide(); }
            if (West) { Select.Four.Text = "Move West"; }else
            { Select.Four.Hide(); }

            Select.ShowDialog();
            switch (Select.returnvalue)
            {
                case "One":
                    pby -= 1;
                    break;
                case "Two":
                    pbx += 1;
                    break;
                case "Three":
                    pby += 1;
                    break;
                case "Four":
                    pbx -= 1;
                    break;
            }
                //Update player coords.
            player.X = pbx;
            player.Y = pby;

                //Show where the player moved
            RevealRoomTile(pbx, pby, PalletizedTiles);
            RevealRoomTile(oldx, oldy, tiles_list);
            //If the room exists run the session for it.


                //But not before checking if we're done! :D HOORAY!
            if (mazemap.Finishroom.X == player.X && mazemap.Finishroom.Y == player.Y)
            {
                SpeechScriptInterpreter finished = new SpeechScriptInterpreter();
                finished.Init_Voice(Program.voicename);
                finished.say_default("You have completed the maze. Congragulations!!!!");
                this.Close();
            }

            if (mazemap.getroomkeystate(pbx, pby))
            {
                Console.WriteLine("The room at " + pbx + ", " + pby + " was obviously found. DuUUH");
            }
            MazeRoom currentroom = mazemap.GetRoomByIteration(pbx, pby);
            if (!currentroom.ran_once)
            {
                currentroom.ran_once = true;
                mazemap.rooms[new Vector2<int, int>(pbx, pby)] = currentroom;
                RunRoomSession();
            }
            else
            {
                Player_Move();
            }
        }

        public void RunRoomSession()
        {
            MazeRoom currentroom = mazemap.GetRoomByIteration(player.X, player.Y);
            string ScriptName = currentroom.SessionName;

                //Only parse the script if the name isn't blank
            if (currentroom.SessionName != "")
            {
                ScriptRepresentation script = new ScriptRepresentation();
                //Initialize the script
                script.init(ScriptName);
                SpeechScriptInterpreter RoomRunner = new SpeechScriptInterpreter();
                if (FirstRun)
                {
                    RoomRunner.init();
                    FirstRun = false;
                }else
                {
                    RoomRunner.Init_Voice(Program.voicename);
                }
                RoomRunner.parse(ScriptName);
                //Console.WriteLine(ScriptName);
            }
            //Move the player again.
            Player_Move();
        }

        public void make_map(Vector2<int, int> startpoint, Vector2<int, int> endpoint, int targetmoves)
        {
            //Step 1, initialize the tile dir data for the 2nd and third phases.
            TileDirData.init();

            //Set the ID type of the starting tile (the start tile icon) and initialize start X and Y and end X and end Y Coords.
            int start_tile = 13;
            int startx = startpoint.X;
            int starty = startpoint.Y;
            int endx = endpoint.X;
            int endy = endpoint.Y;

            //Set the start location for the player 
            this.player.X = startpoint.X;
            this.player.Y = startpoint.Y;

            //Now we can start the first maze logic hooray

            string startname = startx + "," + starty;
            PictureBox p = new PictureBox();
            Control ctn = this.Controls[startname];
            p = (PictureBox)ctn;

            Random S = new Random();
            int facingdir = S.Next(1, 5);
            int startingtilenum = 0;

            //Select the starting facing direction 
            int mousefacingdir = 0;
            int mousex = startpoint.X;
            int mousey = startpoint.Y;


            p.Image = tiles_list[13].localtile;
            p.Click += this.onclick_;
            tmap.map[mousex, mousey].TileType = start_tile;


            Vector2<int, int> currentpos = startpoint;
            //Using the current pos vector of Int, Int, initialize a new MazeRoom object.
            MazeRoom StartRoom = new MazeRoom();
            //Set the start room metadata
            StartRoom.MetaData = "StartRoom";
            //Set the start Room's X and Y
            StartRoom.X = currentpos.X;
            StartRoom.Y = currentpos.Y;

            //Lastly when dealing with the Start Room we need to add it to the rooms dictionary interface
            mazemap.AddRoom(currentpos, StartRoom);
            coords_.Add(currentpos);


            int steps_left = 5;
            for (int moves = 0; moves < targetmoves; moves++)
            {

                //First determine our facing direction
                mousefacingdir = facingdir;
                //Next move the mouse in the facing direction.
                currentpos = movemouse(mousex, mousey, facingdir);


                //figure out which way the mouse moved
                mousex = currentpos.X;
                mousey = currentpos.Y;
                //A safety binding to prevent out of bounds to the left...and up
                if (mousex < 0) { mousex = 0; }
                if (mousey < 0) { mousey = 0; }
                if (mousex > tmap.width) { mousex = tmap.width; }
                if (mousey > tmap.height) { mousey = tmap.height; }

                currentpos.X = mousex;
                currentpos.Y = mousey;
                string pos_string = mousex + "," + mousey;
                //StartRoom.SessionName = "Scripts/InductionTest.txt";
                MazeRoom TempNewRoom = new MazeRoom();
                TempNewRoom.MetaData = "CreatedRoom";
                mazemap.AddRoom(currentpos, TempNewRoom);
                //new object();




                //and get the control we are on
                p = new PictureBox();
                ctn = this.Controls[pos_string];
                if (ctn != null)
                {
                    if (tmap.map[mousex, mousey].TileType != start_tile) { p = (PictureBox)ctn; }
                }

                if (p != null)
                {
                    p.Click += this.onclick_;
                    steps_left -= 1;

                    //Trying to undo start tile replacement.
                    if (currentpos != startpoint)
                    {
                            //This effects all tiles but the start
                        p.Image = tiles_list[0].localtile;
                        this.Refresh();
                    }
                    if (steps_left <= 0)
                    {
                        steps_left = S.Next(1, 9);
                        //Randomize the direction of mouse again
                        facingdir = S.Next(1, 5);
                    }

                }

                //Console.WriteLine("Moves are " + moves + "And target moves is " + targetmoves);

                //Console.Clear();
                Console.SetCursorPosition(mousex, mousey);
                Console.Write("X");
                for (int x = 0; x < 15; x++)
                {
                    for (int y = 0; y < 15; y++)
                    {
                        Console.SetCursorPosition(x, y);
                        bool state = mazemap.getroomkeystate(x, y);
                        if (state)
                        {
                            Console.Write("#");
                        }

                    }
                }
                System.Threading.Thread.Sleep(15);



            }


            //Phase 2 of the system is to figure out room neighboors data.
            //We can do this just using the MazeMap dictionary interface and nothing else.
            //Copy the dictionary
            //Console.WriteLine("This ran");
            Dictionary<Vector2<int, int>, MazeRoom> RoomDict = mazemap.rooms;

            foreach (KeyValuePair<Vector2<int, int>, MazeRoom> roompair in RoomDict)
            {
                //Console.WriteLine("An item exists here");
                //Now we need to extract some data to process it
                MazeRoom temproom = roompair.Value;
                Vector2<int, int> Location = roompair.Key;
                int RoomX = Location.X;
                int RoomY = Location.Y;

                //Console.WriteLine("Room X is " + RoomX + " | Room Y is " + RoomY);
                /*
                   Corner Tile Numbers
                   NorthEast 13
                   SouthEast 14
                   NorthWest 15
                   SouthWest 16
                   */



                //Let's try the function form instead of the below

                //RevealRoomTile(Location.X, Location.Y, tiles_list);

                if (RoomX == mazemap.Finishroom.X && RoomY == mazemap.Finishroom.Y)
                {   //Show them where the finish room is atleast ;P
                    RevealRoomTile(RoomX, RoomY, PalletizedTiles);
                }
                //And the above line simplifies everything to a function
                    //Hooray.



                    /*

                //It is time to check neighboors by using containskey.

                Vector2<int, int> North = new Vector2<int, int>(RoomX, RoomY - 1);
                Vector2<int, int> East = new Vector2<int, int>(RoomX + 1, RoomY);
                Vector2<int, int> South = new Vector2<int, int>(RoomX, RoomY + 1);
                Vector2<int, int> West = new Vector2<int, int>(RoomX - 1, RoomY);

                //We also need an instance of the struct which the class MazeRoom Provides
                MazeRoom.ExitData TempExitData = new MazeRoom.ExitData();

                //Okay now after this we can use contains key and set the data for each direction as well.
                if (RoomDict.ContainsKey(North)) { TempExitData.NorthExit = true; }
                if (RoomDict.ContainsKey(East)) { TempExitData.EastExit = true; }
                if (RoomDict.ContainsKey(South)) { TempExitData.SouthExit = true; }
                if (RoomDict.ContainsKey(West)) { TempExitData.WestExit = true; }

                roompair.Value.LocalExits = TempExitData;

                string TileControlName = RoomX + "," + RoomY;
                Vector2<int, int> RoomPos = new Vector2<int, int>(RoomX, RoomY);
                PictureBox Tile = new PictureBox();
                Control TileCtn = this.Controls[TileControlName];
                Tile = (PictureBox)TileCtn;

                //A fix to see if 4 ways can work.
                if (Tile != null)
                {
                    Tile.Image = tiles_list[1].localtile;

                    //Save the value
                    int neighboor_count = mazemap.CountNeighboors(RoomX, RoomY);

                    if (neighboor_count == 4)
                    {
                        Tile.Image = tiles_list[2].localtile;
                    }

                    //We need to know exact states
                    bool NorthNeighboor = mazemap.getroomkeystate(RoomX, RoomY - 1);
                    bool SouthNeighboor = mazemap.getroomkeystate(RoomX, RoomY + 1);
                    bool EastNeighboor = mazemap.getroomkeystate(RoomX + 1, RoomY);
                    bool WestNeighboor = mazemap.getroomkeystate(RoomX - 1, RoomY);


                   



                    //solving hallways first
                    if (neighboor_count == 2)
                    {
                        if (NorthNeighboor && SouthNeighboor)
                        {
                            Tile.Image = tiles_list[3].localtile;
                        }

                        if (EastNeighboor && WestNeighboor)
                        {
                            Tile.Image = tiles_list[4].localtile;
                        }

                        //Dealing with corner tiles below.

                        //NorthEast Neighboor Case
                        if (NorthNeighboor && EastNeighboor)
                        {
                            Tile.Image = tiles_list[13].localtile;
                        }
                        //SouthEast Neighboor Case
                        if (SouthNeighboor && EastNeighboor)
                        {
                            Tile.Image = tiles_list[14].localtile;
                        }
                        //NorthWest Neighboor Case
                        if (NorthNeighboor && WestNeighboor)
                        {
                            Tile.Image = tiles_list[15].localtile;
                        }
                        //SouthWest Neighboor Case
                        if (SouthNeighboor & WestNeighboor)
                        {
                            Tile.Image = tiles_list[16].localtile;
                        }




                    }

                    //Solving one way exits/entrances
                    if (neighboor_count == 1)
                    {
                        if (NorthNeighboor)
                            Tile.Image = tiles_list[10].localtile;

                        if (SouthNeighboor)
                            Tile.Image = tiles_list[9].localtile;
                        if (EastNeighboor)
                            Tile.Image = tiles_list[12].localtile;
                        if (WestNeighboor)
                            Tile.Image = tiles_list[11].localtile;
                    }

                    //Now the hardest one. Three ways.
                    if (neighboor_count == 3)
                    {
                        if (!SouthNeighboor)
                        {
                            Tile.Image = tiles_list[8].localtile;
                            //Console.WriteLine("South Sealed at " + RoomX + "," + RoomY);
                        }

                        if (!NorthNeighboor)
                        {
                            Tile.Image = tiles_list[7].localtile;
                            //Console.WriteLine("North Sealed at " + RoomX + "," + RoomY);
                        }

                        if (!EastNeighboor)
                        {
                            Tile.Image = tiles_list[6].localtile;
                            //Console.WriteLine("East Sealed at " + RoomX + "," + RoomY);
                        }

                        if (!WestNeighboor)
                        {
                            if (NorthNeighboor && SouthNeighboor && EastNeighboor)
                            {
                                //Attempting to eliminate a bug
                                Tile.Image = tiles_list[5].localtile;

                                // Console.WriteLine("West Sealed at " + RoomX + "," + RoomY);
                            }
                        }
                    }

                    //TempControlsCtn = TempControlsPbox;

                
                }


                */
                //With all this set
                //The maze should somehow now show us the correct images.

            }
            //this.done_generating = true;
            //this.Show();
            this.Show();
            //this.done_generating = true;
            //Console.WriteLine("Reached finish somehow");


        }

        public Vector2<int, int> movemouse(int x, int y, int direction)
        {
            Vector2<int, int> mousepos = new Vector2<int, int>(x, y);
            switch (direction)
            {
                case 1:
                    mousepos.Y -= 1;
                    break;
                case 2:
                    mousepos.Y += 1;
                    break;
                case 3:
                    mousepos.X += 1;
                    break;
                case 4:
                    mousepos.X -= 1;
                    break;
            }

            return mousepos;
        }

        private void makefile()
        {
            string[] lines = new string[18];
            for (int y = 0; y < 16; y++)
            {
                string line = "";
                for (int x = 0; x < 16; x++)
                {

                    if (tmap.map[x, y].TileType < 10) { line = line + tmap.map[x, y].TileType + ", "; }
                    else
                        line = line + tmap.map[x, y].TileType + ",";
                }
                lines[y] = line;
            }
            File.WriteAllLines("C://stuff//lines.txt", lines);
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            //Run the load function
            get_tiles("roomicons.png", tiles_list);
                //Load a Palletized version of these tiles so we can switch between them.
            get_tiles("PalletizedRoomIcons.png", PalletizedTiles);

            //MapFormLoad(sender, e);
            tmap = new TileMap(new Vector2<int, int>(15, 15));
            TileGraphic[,] tmap_ = new TileGraphic[32, 32];
            tmap.map = tmap_;
            MapFormLoad(sender, e);

                //Adding the random start point.
            Random Maprandomizer = new Random();
            int startx = Maprandomizer.Next(0, 15);
            int starty = Maprandomizer.Next(0, 15);

            int endx = Maprandomizer.Next(0, 15);
            int endy = Maprandomizer.Next(0, 15);

                //Set the finish room
            mazemap.SetFinishRoom(endx, endy);
            //Make the map and finish making it.
            mazemap.SetStartRoom(startx, starty);
            make_map(new Vector2<int, int>(startx, starty), new Vector2<int, int>(endx, endy), 250);
            //make_map(new Vector2<int, int>(5, 5), new Vector2<int, int>(6, 6), 25);
        }

        public void UpdateTileAt(int x, int y, int TileNum)
        {
            PictureBox s = new PictureBox();
            s = (PictureBox)this.Controls[x+","+y];
            if (s != null)
            {
                s.Image = this.tiles_list[TileNum].localtile;
            }
        }

        public void RevealRoomTile(int x, int y, List<TileGraphic> tileset)
        {
            //Console.WriteLine("An item exists here");
            //Now we need to extract some data to process it
            MazeRoom temproom = mazemap.GetRoom(new Vector2<int, int>(x, y)); //roompair.Value;
            Vector2<int, int> Location = new Vector2<int, int>(x, y);
            int RoomX = Location.X;
            int RoomY = Location.Y;

            //Console.WriteLine("Room X is " + RoomX + " | Room Y is " + RoomY);


            //It is time to check neighboors by using containskey.
            //This method using containskey seems to not even work. Will test later.
                //Todo -> Re test room neighboor checking using containskey, for now the function 
                    //getroomkeystate of mazemap object will do.
            Vector2<int, int> North = new Vector2<int, int>(RoomX, RoomY - 1);
            Vector2<int, int> East = new Vector2<int, int>(RoomX + 1, RoomY);
            Vector2<int, int> South = new Vector2<int, int>(RoomX, RoomY + 1);
            Vector2<int, int> West = new Vector2<int, int>(RoomX - 1, RoomY);


                //Todo
                    //Remove stuff like TempExit references they are unused.

            //We also need an instance of the struct which the class MazeRoom Provides
            MazeRoom.ExitData TempExitData = new MazeRoom.ExitData();

            //Okay now after this we can use contains key and set the data for each direction as well.
            if (mazemap.rooms.ContainsKey(North)) { TempExitData.NorthExit = true; }
            if (mazemap.rooms.ContainsKey(East)) { TempExitData.EastExit = true; }
            if (mazemap.rooms.ContainsKey(South)) { TempExitData.SouthExit = true; }
            if (mazemap.rooms.ContainsKey(West)) { TempExitData.WestExit = true; }

            temproom.LocalExits = TempExitData;
            //TempExitData isn't used

            string TileControlName = RoomX + "," + RoomY;
            Vector2<int, int> RoomPos = new Vector2<int, int>(RoomX, RoomY);
            PictureBox Tile = new PictureBox();
            Control TileCtn = this.Controls[TileControlName];
            Tile = (PictureBox)TileCtn;

            //A fix to see if 4 ways can work.
            if (Tile != null)
            {
                Tile.Image = tileset[1].localtile;

                //Save the value
                int neighboor_count = mazemap.CountNeighboors(RoomX, RoomY);

                if (neighboor_count == 4)
                {
                    Tile.Image = tileset[2].localtile;
                }

                //We need to know exact states
                bool NorthNeighboor = mazemap.getroomkeystate(RoomX, RoomY - 1);
                bool SouthNeighboor = mazemap.getroomkeystate(RoomX, RoomY + 1);
                bool EastNeighboor = mazemap.getroomkeystate(RoomX + 1, RoomY);
                bool WestNeighboor = mazemap.getroomkeystate(RoomX - 1, RoomY);

                    //use these instead for exit metadata later. =p
                temproom.SetAllExits(NorthNeighboor, EastNeighboor, WestNeighboor, SouthNeighboor);


                /*
                Corner Tile Numbers
                NorthEast 13
                SouthEast 14
                NorthWest 15
                SouthWest 16
                */

                //solving hallways first
                if (neighboor_count == 2)
                {
                    if (NorthNeighboor && SouthNeighboor)
                    {
                        Tile.Image = tileset[3].localtile;
                    }

                    if (EastNeighboor && WestNeighboor)
                    {
                        Tile.Image = tileset[4].localtile;
                    }

                    //Dealing with corner tiles below.

                    //NorthEast Neighboor Case
                    if (NorthNeighboor && EastNeighboor)
                    {
                        Tile.Image = tileset[13].localtile;
                    }
                    //SouthEast Neighboor Case
                    if (SouthNeighboor && EastNeighboor)
                    {
                        Tile.Image = tileset[14].localtile;
                    }
                    //NorthWest Neighboor Case
                    if (NorthNeighboor && WestNeighboor)
                    {
                        Tile.Image = tileset[15].localtile;
                    }
                    //SouthWest Neighboor Case
                    if (SouthNeighboor & WestNeighboor)
                    {
                        Tile.Image = tileset[16].localtile;
                    }

                }

                //Solving one way exits/entrances
                if (neighboor_count == 1)
                {
                    if (NorthNeighboor)
                        Tile.Image = tileset[10].localtile;

                    if (SouthNeighboor)
                        Tile.Image = tileset[9].localtile;
                    if (EastNeighboor)
                        Tile.Image = tileset[12].localtile;
                    if (WestNeighboor)
                        Tile.Image = tileset[11].localtile;
                }

                //Now the hardest one. Three ways.
                if (neighboor_count == 3)
                {
                    if (!SouthNeighboor)
                    {
                        Tile.Image = tileset[8].localtile;
                        //Console.WriteLine("South Sealed at " + RoomX + "," + RoomY);
                    }

                    if (!NorthNeighboor)
                    {
                        Tile.Image = tileset[7].localtile;
                        //Console.WriteLine("North Sealed at " + RoomX + "," + RoomY);
                    }

                    if (!EastNeighboor)
                    {
                        Tile.Image = tileset[6].localtile;
                        //Console.WriteLine("East Sealed at " + RoomX + "," + RoomY);
                    }

                    if (!WestNeighboor)
                    {
                        if (NorthNeighboor && SouthNeighboor && EastNeighboor)
                        {
                            //Attempting to eliminate a bug
                            Tile.Image = tileset[5].localtile;
                        }
                    }
                }

              


            }
    }

            //parameter TilesList is different from local tileslist
        public void get_tiles(string directory, List<TileGraphic> TilesList)
        {
            int tileWidth = 64;
            int tileHeight = 64;
            int tileRows = 10;
            int tileCols = 10;

            using (Bitmap sourceBmp = new Bitmap(directory))
            {
                Size s = new Size(tileWidth, tileHeight);
                Rectangle destRect = new Rectangle(Point.Empty, s);
                for (int y = 0; y < tileRows; y++)
                    for (int x = 0; x < tileCols; x++)
                    {
                        Point loc = new Point(tileWidth * x, tileHeight * y);
                        Rectangle srcRect = new Rectangle(loc, s);
                        Bitmap tile = new Bitmap(tileWidth, tileHeight);
                        Graphics G = Graphics.FromImage(tile);
                        G.DrawImage(sourceBmp, destRect, srcRect, GraphicsUnit.Pixel);
                        TileGraphic t = new TileGraphic();
                        t.localtile = tile;  //Set the graphic in the local tile
                        t.name = String.Format("{0:00}", "{1:00}", x, y);
                        TilesList.Add(t);
                    }
            }


        }

    }
}

        
    

