using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectorGenerator
{
    class SectorVisualizer
    {
        private int _mapX;
        private int _mapY;

        public SectorVisualizer(int x, int y)
        {
            _mapX = x;
            _mapY = y;
        }

        //Ideally I'd pass in an array of sector info so be printed, but for now it'll just display a
        //blank map of the set size I've designated...
        //← ↑ → ↓ ↔ ↕ = whether or not a sector can access another
        //◌ = black hole
        //☼ = a sun system
        //# = any number of planets
        public void DrawSectorMap(Sector[] map)
        {
            int totalIndex = 0;
            for (int x = 0; x < _mapX; x++)
            {
                //Draw the sector cell and horizontal connection
                for (int y = 0; y < _mapY; y++)
                {
                    string cellIcon = GetSectorIcon(map[totalIndex]);
                    totalIndex++;

                    if (y == (_mapY - 1))
                        Console.Write("[ " + cellIcon + " ]");
                    else
                        Console.Write("[ " + cellIcon+ " ]↔");
                }

                Console.Write("\n");

                if (x < (_mapX - 1))
                {
                    //Draw only vertical connections
                    for (int y = 0; y < _mapY; y++)
                    {
                        Console.Write("  ↕   ");
                    }
                }

                Console.Write("\n");
            }
        }

        private string GetSectorIcon(Sector cell)
        {
            switch(cell.SectorContents)
            {
                case Sector.CONTENTS.EMPTY:
                    return " ";
                case Sector.CONTENTS.BLACKHOLE:
                    return "x";
                case Sector.CONTENTS.STAR:
                    return "☼";
                default:
                    return cell.Planets.ToString();
            }
        }
    }
}
