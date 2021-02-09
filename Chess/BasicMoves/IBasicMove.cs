namespace Chess
{
    public interface IBasicMove
    {
        void SetMove(Chessman chessman, ChessTable chessTable);
        Square GetNextSquare(Chessman chessman, ChessTable chessTable);
        void SetChange();
    }
}