using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroTimeRPG
{
    class GridTile
    {
        const string defaultType = "open";
        string type;

        bool isOccupied;
        public bool IsOccupied
        {
            get
            {
                return isOccupied;
            }
        }

        GridEntity occupant;
        public GridEntity Occupant
        {
            get
            {
                return occupant;
            }
            set
            {
                if (value == null)
                {
                    isOccupied = false;
                }
                else
                {
                    isOccupied = true;
                }
                occupant = value;
            }
        }

        int x;
        public int X
        {
            get
            {
                return x;
            }
        }

        int y;
        public int Y
        {
            get
            {
                return y;
            }
        }

        public GridTile(int xCoord, int yCoord)
        {
            x = xCoord;
            y = yCoord;
            type = defaultType;
            Occupant = null;
        }


        public GridTile(int xCoord, int yCoord, string tileType)
        {
            x = xCoord;
            y = yCoord;
            type = tileType;
            Occupant = null;
        }


        public GridTile(int xCoord, int yCoord, GridEntity tileOccupant)
        {
            x = xCoord;
            y = yCoord;
            type = defaultType;
            Occupant = tileOccupant;
        }


        public GridTile(int xCoord, int yCoord, string tileType, GridEntity tileOccupant)
        {
            x = xCoord;
            y = yCoord;
            type = tileType;
            Occupant = tileOccupant;
        }
    }
}
