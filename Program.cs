using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestChess.Figures;

namespace TestChess
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureRegistry = new FigureRegistry();
            figureRegistry.LoadFigures();

            //var baseAssembly = typeof(AbstractFigure)

            //var chessBoard = new ChessBoard();
            //chessBoard.PrintForWhiteNumbers();
            Console.ReadKey();
        }
    }
}
