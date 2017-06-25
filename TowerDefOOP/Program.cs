using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefOOP.exceptions;
using TowerDefOOP.levels;
using TowerDefOOP.objects;

namespace TowerDefOOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Map map = new Map(50, 70);
            try
            {
                MapLocation[] mapPath = {
                        new MapLocation(0,2,map),
                        new MapLocation(1,2,map),
                        new MapLocation(2,2,map),
                        new MapLocation(3,2,map),
                        new MapLocation(4,2,map),
                        new MapLocation(5,2,map),
                        new MapLocation(6,2,map),
                        new MapLocation(7,2,map),

                };

                Path path = new Path(mapPath);

                Invader[] invaders =
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)

                };
                Tower[] towers = {
                    new Tower(new MapLocation(1,3, map)),
                    new Tower(new MapLocation(3,3, map)),
                    new Tower(new MapLocation(5,3, map)),

                };
                Level level = new Level(invaders) {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player "+(playerWon ? "Won" : "Lost"));

             //   MapLocation point1 = new MapLocation(4, 2, map);

             //   Console.WriteLine("Map height is: " + map.Height + " width is: " + map.Width);
             //   Console.WriteLine("Map area is: " + map.Area());
            //    Console.WriteLine("X: " + point1.XCoord + " y:" + point1.YCoord + " on Map: " + map.OnMap(point1) + " distance to point: " + point1.DistanceTo(5, 5));
               

            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}
