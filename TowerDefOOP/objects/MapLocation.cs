using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefOOP.exceptions;

namespace TowerDefOOP.objects
{
    class MapLocation : Point
    {
        public MapLocation(int xCoord, int yCoord, Map map) : base(xCoord, yCoord)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(xCoord+","+yCoord+" is outside the bounds of the map");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }

}
