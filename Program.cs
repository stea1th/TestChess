﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChess
{
    class Program
    {
        static void Main(string[] args)
        {
            var chessBoard = new ChessBoard();
            chessBoard.PrintForWhiteNumbers();
            Console.ReadKey();
        }
    }
}
