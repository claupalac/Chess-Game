namespace Chess
{
    public interface IBasicMove
    {
        void SetMove(IChessman chessman, IChessTable chessTable);
        ISquare GetNextSquare(IChessman chessman, IChessTable chessTable);
        void SetChange();
    }
}