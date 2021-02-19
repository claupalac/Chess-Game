namespace Chess
{
    public interface IChessTable
    {
        bool IsValidPosition(IPosition position);
        void SetChessman(IChessman chessman, IPosition position);
    }
}