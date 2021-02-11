namespace Chess
{
    public class Player
    {
        public Player()
        {
            
        }

        public void ShowMovesFromChessman(Chessman chessman, ChessTable chessTable)
        {
            IChessmanMovement theMoves = chessman.GetMovement();
            theMoves.ShowPossibleMoves(chessman,chessTable);
        }
    }
}