using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefOOP.objects
{
    class Point
    {
        public int XCoord { get; private set; }
        public int YCoord { get; private set; }

        public Point(int xCoord, int yCoord)
        {
            XCoord = xCoord;
            YCoord = yCoord;
        }

        public int DistanceTo(int x, int y)
        {
            int output =(int)Math.Sqrt(Math.Pow((XCoord - x), 2) + Math.Pow((YCoord - y),2));
            return output;
        }

        public int DistanceTo(MapLocation location)
        {

            int output = (int)Math.Sqrt(Math.Pow((XCoord - location.XCoord), 2) + Math.Pow((YCoord - location.YCoord), 2));
            return output;
        }

    }
}
