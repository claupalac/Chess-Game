namespace Chess
{
    public interface IBasicMove
    {
        void SetMove(Chessman chessman, ChessTable chessTable);
        ISquare GetNextSquare(Chessman chessman, ChessTable chessTable);
        void SetChange();
    }
}