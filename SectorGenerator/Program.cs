using System;

namespace SectorGenerator
{
    class Program
    {
        private static int _mapSize = 10;
        private static bool _end = false;

        private static SectorVisualizer _sectorVisualizer;
        private static Sector[] _sectorsMap;

        static void Main(string[] args)
        {
            _sectorVisualizer = new SectorVisualizer(_mapSize, _mapSize);
            _sectorsMap = new Sector[_mapSize * _mapSize];

            for (int i = 0; i < (_mapSize * _mapSize); i++)
            {
                _sectorsMap[i] = new Sector();
            }

            while (!_end)
            {
                _sectorVisualizer.DrawSectorMap(_sectorsMap);
                _end = CheckEndState(Console.ReadLine());
            }

            Console.WriteLine("\n\nExiting...");
        }

        static bool CheckEndState(string input)
        {
            switch (input.ToLower())
            {
                case "x":
                    return true;
                case "close":
                    return true;
                case "leave":
                    return true;
                case "exit":
                    return true;
                case "end":
                    return true;
                default:
                    return false;
            }
        }
    }
}
