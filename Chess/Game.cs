using System;
using System.Collections.Generic;
using Chess.Factory;

namespace Chess
{
    public class Game
    {
        public IChessTable ChessTable { get; set; }
        private Dictionary<IChessman, IPosition> _chessmansDictionary;
        public Game(IChessTable chessTable)
        {
            ChessTable = chessTable;
            _chessmansDictionary = new Dictionary<IChessman, IPosition>();
        }

        public void PutChessmanOnChessTable(IChessman chessman, IPosition position)
        {
            ChessTable.SetChessman(chessman,position);
            _chessmansDictionary.Add(chessman,position);
        }

        public void ShowMoves(IChessman chessman)
        {
            IChessmanMovement chessmanMovement = chessman.MyPlays();
            IPosition fromPosition = _chessmansDictionary[chessman];
            foreach (var position in chessmanMovement.GetPossibleMoves(fromPosition,ChessTable))
            {
                Console.WriteLine(position);
            }

        }

    }
}