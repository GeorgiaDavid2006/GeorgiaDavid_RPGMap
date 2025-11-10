using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_RPGMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Map Legend:");
            Console.WriteLine("` = grass");
            Console.WriteLine("^ = mountain");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");

            DisplayMap();
            DisplayMap(2);
        }



        static char[,] map = new char[,]
        {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };


        static void DisplayMap()
        {
            for (int border = 0; border < map.GetLength(1) + 2; border++)
            {
                if (border == 0 || border == map.GetLength(1) + 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.Write("\n");

            for (int row = 0; row < map.GetLength(0); row++)
            {
                Console.Write("|");
                for (int column = 0; column < map.GetLength(1); column++)
                {
                    Console.Write(map[row, column]);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            for (int border = 0; border < map.GetLength(1) + 2; border++)
            {
                if (border == 0 || border == map.GetLength(1) + 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }

        static void DisplayMap(int scale)
        {
            for (int border = 0; border < map.GetLength(1) * scale + 2; border++)
            {
                if (border == 0 || border == map.GetLength(1) * scale + 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine("\n");

            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int duplicaterow = 0; duplicaterow < scale; duplicaterow++)
                {
                    for (int column = 0; column < map.GetLength(1); column++)
                    {
                        for (int duplicatecolumn = 0; duplicatecolumn < scale; duplicatecolumn++)
                        {
                            Console.Write(map[row, column]);
                        }
                    }
                }
                
            }
            Console.Write("|");
            Console.WriteLine();

            for (int border = 0; border < map.GetLength(1) * scale + 2; border++)
            {
                if (border == 0 || border == map.GetLength(1) * scale + 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }
    }
}
