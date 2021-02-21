using System;
namespace _2012_Bio
{
    class Program
    {
        static void Main(string[] args)
        {
            Junction[] journey = {new Junction('A', 'D', 'E', 'F') ,
                new Junction ('B', 'C', 'G', 'H'),
                new Junction ('C', 'B', 'I', 'J'),
                new Junction('D', 'A', 'K', 'L'),
                new Junction('E', 'A', 'M', 'N'),
                new Junction('F', 'A', 'N', 'O'),
                new Junction('G', 'B', 'O', 'P'),
                new Junction('H', 'B', 'P', 'Q'),
                new Junction('I', 'C', 'Q', 'R'),
                new Junction('J', 'C', 'R', 'S'),
                new Junction('K', 'D', 'S', 'T'),
                new Junction('L', 'D', 'T', 'M'),
                new Junction('M', 'U', 'L', 'E'),
                new Junction('N', 'U', 'E', 'F'),
                new Junction('O', 'V', 'F', 'G'),
                new Junction('P', 'V', 'G', 'H'),
                new Junction('Q', 'W', 'H', 'I'),
                new Junction('R', 'W', 'I', 'J'),
                new Junction('S', 'X', 'J', 'K'),
                new Junction('T', 'X', 'K', 'L'),
                new Junction('U', 'V', 'M', 'N'),
                new Junction('V', 'U', 'O', 'P'),
                new Junction('W', 'X', 'Q', 'R'),
                new Junction('X', 'W', 'S', 'T') };
            //Journey journey1 = new Journey("GHIJKL", "AE", 6, journey);
            Journey journey2 = new Journey("ABCDEF", "GO", 92, journey);
        }
    }
}
