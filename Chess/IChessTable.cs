namespace Chess
{
    public interface IChessTable
    {
        bool IsValidPosition(int positionX, int positionY);
        void SetChessman(IChessman chessman, int posX, int posY);
    }
}