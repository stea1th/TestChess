using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestChess.Figures;

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

        public void printForWhite(Dictionary<int, IFigure> figures)
        {
            for (int row = 0; row < _boardSize; row++)
            {
                Console.WriteLine();
                Console.WriteLine(_threeSpaces + "---------------------------------");
                for (int column = 0; column <= _boardSize; column++)
                {
                    if(column == 0)
                    {
                        Console.Write(_oneSpace + (_boardSize - row) + _oneSpace);
                    } 
                    else
                    {
                        int num = column + _boardSize * row;
                        figures.TryGetValue(num, out var figure);
                        string cell = figure != null && figure.Alive ? _oneSpace + figure.View : GetEmptyCell(row, num, true);
                        Console.Write("|" + cell);
                    }
                }
                Console.Write("|");
            }
            Console.WriteLine();
            Console.WriteLine(_threeSpaces + "---------------------------------");
            Console.WriteLine(_threeSpaces + CreateLettersChain());
            Console.WriteLine();
        } 



        private string CreateLettersChain()
        {
            var letters = Enumerable.Range(65, 72).Select(x => (char)x).ToList().GetRange(0, 8);
            var stringBuilder = new StringBuilder(_twoSpaces);
            letters.ForEach(x => stringBuilder.Append(x).Append(_threeSpaces));
            return stringBuilder.ToString();
        }

        private string GetEmptyCell(int row, int num, bool isWhite)
        {
            string white = _threeSpaces;
            string black = "===";
            int expr = isWhite ? 1 : 0;
            if(row % 2 == 0)
            {
                return num % 2 == expr ? white : black;
            }
            else
            {
                return num % 2 == expr ? black : white;
            }
        }
    }
}
