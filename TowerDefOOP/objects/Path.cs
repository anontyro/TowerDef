using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefOOP.objects
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            if(pathStep > _path.Length)
            {
                return null;
            }
            return _path[pathStep];

        }

    }
}
