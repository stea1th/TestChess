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
            bool whiteMove = true;
            var confReader = new ConfigurationReader();
            var configuration = confReader.GetConfiguration();
            var figureRegistry = new FigureRegistry(configuration);
            figureRegistry.LoadFigureTypes();
            figureRegistry.SetFiguresOnPosition();
            var figuresOnPosition = figureRegistry.FiguresOnPosition;
            var chessBoard = new ChessBoard(figuresOnPosition);
            var turnConverter = new TurnConverter();
            while (true)
            {
                if (whiteMove)
                {
                    chessBoard.PrintForWhite();
                }
                else 
                {
                    chessBoard.PrintForBlack(); 
                }
                var turn = chessBoard.ReadFromConsole();
                var arr = turnConverter.Convert(turn);
                chessBoard.MoveFigure(arr[0], arr[1]);
                whiteMove = !whiteMove;
            }

            //var turnConverter = new TurnConverter();
            //var list = turnConverter.Match("e2 H   A5");
            //list.ForEach(x => Console.WriteLine(x));
            //var x = turnConverter.TransformToIntArray(list);
            //Console.WriteLine(x[0]);
            //Console.WriteLine(x[1]);

            //Console.WriteLine(list.Count);

            //var confReader = new ConfigurationReader();
            //var configuration = confReader.GetConfiguration();
            //var figureRegistry = new FigureRegistry(configuration);
            //figureRegistry.LoadFigureTypes();
            //figureRegistry.SetFiguresOnPosition();
            //var figuresOnPosition = figureRegistry.FiguresOnPosition;
            //var chessBoard = new ChessBoard();
            //chessBoard.PrintForWhite(figuresOnPosition);
            //Thread.Sleep(5000);
            //chessBoard.PrintForBlack(figuresOnPosition);
            //Thread.Sleep(5000);
            //chessBoard.PrintForWhite(figuresOnPosition);


            Console.ReadKey();
        }
    }
}
