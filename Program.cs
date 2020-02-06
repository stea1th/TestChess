using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
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
            //figureRegistry.FiguresOnPosition.Values.ToList().ForEach(x => Console.WriteLine(x.View + " " + x.Position + " " + x.Name));
            var figuresOnPosition = figureRegistry.FiguresOnPosition;
            var chessBoard = new ChessBoard();
            chessBoard.printForWhite(figuresOnPosition);


            //var baseAssembly = typeof(AbstractFigure)

            //var chessBoard = new ChessBoard();
            //chessBoard.PrintForWhiteNumbers();
            Console.ReadKey();
        }
    }
}
