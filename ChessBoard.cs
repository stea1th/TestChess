using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChess
{
    class ChessBoard
    {

        private readonly int _boardSize = 8;
        private readonly string _threeSpaces = "   ";
        private readonly string _twoSpaces = "  ";
        private readonly string _oneSpace = " ";

        public void PrintForWhiteNumbers()
        {
            for (int row = 0; row < _boardSize; row++)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                for (int column = 1; column <= _boardSize; column++)
                {
                    string num = (column + _boardSize * row).ToString();
                    Console.Write("| " + (num.Length == 1 ? num + _oneSpace : num));
                }
                Console.Write("|");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
        } 

    }
}
