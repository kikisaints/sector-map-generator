using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectorGenerator
{
    class Sector
    {
        public enum CONTENTS
        {
            EMPTY = 0,
            BLACKHOLE,
            STAR,
            PLANETS
        };

        private Random _rand = new Random();
        private CONTENTS _sectorContents;
        private int _planets = 0;

        public CONTENTS SectorContents
        {
            get { return _sectorContents; }
        }

        public int Planets
        {
            get { return _planets; }
        }

        public Sector()
        {
            GenerateSectorContents(_rand.Next(-2, 10));            
        }

        private void GenerateSectorContents(int seed)
        {
            switch (seed)
            {
                case -2:
                    _sectorContents = CONTENTS.EMPTY;
                    break;
                case -1:
                    _sectorContents = CONTENTS.BLACKHOLE;
                    break;
                case 0:
                    _sectorContents = CONTENTS.STAR;
                    break;
                default:
                    _sectorContents = CONTENTS.PLANETS;
                    _planets = seed;
                    break;

            }
        }
    }
}
