using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestChess.Engine;
using TestChess.Figures;
using TestChess.GameConfiguration;
using TestChess.Util;

namespace TestChess
{
    class Program
    {
        protected Program()
        {
        }

        static void Main(string[] args)
        {

            IChessEngine chessEngine = new ChessEngine();
            var chessBoard = new ChessBoard();
            var turn = chessEngine.InitGame();
            while (true)
            {
                if (turn.WhiteMove)
                {
                    chessBoard.PrintForWhite(turn.Figures);
                }
                else 
                {
                    chessBoard.PrintForBlack(turn.Figures); 
                }
                var message = chessBoard.ReadFromConsole();
                turn = chessEngine.MakeATurn(message);
            }
        }
    }
}
