using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefOOP.objects
{
    class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;

        }

        public int Area()
        {
            return Width * Height;
        }

        public bool OnMap(Point point)
        {
            if(point.XCoord >=0 && point.XCoord < Width &&
                point.YCoord >=0 && point.YCoord < Height)
            {
                return true;
            }

            return false;
        }


    }
}
