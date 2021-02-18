namespace Chess
{
    public class MoveBackward : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            originalPosition.PositionY = originalPosition.PositionY--;
            return originalPosition;
        }
    }
}