using System;

namespace Chess
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ChessTable chessTable = new ChessTable(8, 8);
            Game game = new Game(chessTable);
            IChessman chessman = new King();
            IPosition position = new Position(0,0);
            
            game.PutChessmanOnChessTable(chessman,position);
            game.ShowMoves(chessman);
            Console.WriteLine(position);

        }
    }
}