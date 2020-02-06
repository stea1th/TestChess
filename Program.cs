using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestChess.Figures;
using TestChess.GameConfiguration;

namespace TestChess
{
    class Program
    {
        protected Program()
        {
        }

        static void Main(string[] args)
        {

            var confReader = new ConfigurationReader();
            var configuration = confReader.GetConfiguration();
            var figureRegistry = new FigureRegistry(configuration);
            figureRegistry.LoadFigureTypes();
            figureRegistry.SetFiguresOnPosition();
            var figuresOnPosition = figureRegistry.FiguresOnPosition;
            var chessBoard = new ChessBoard();
            chessBoard.PrintForWhite(figuresOnPosition);
            Thread.Sleep(5000);
            chessBoard.PrintForBlack(figuresOnPosition);
            Thread.Sleep(5000);
            chessBoard.PrintForWhite(figuresOnPosition);


            Console.ReadKey();
        }
    }
}
