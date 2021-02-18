namespace Chess
{
    public class MoveBackwardLeft : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            originalPosition.PositionY = originalPosition.PositionY--;
            originalPosition.PositionX = originalPosition.PositionX--;
            return originalPosition;
        }
    }
}