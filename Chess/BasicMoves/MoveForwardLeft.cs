namespace Chess
{
    public class MoveForwardLeft : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            originalPosition.PositionY = originalPosition.PositionY++;
            originalPosition.PositionX = originalPosition.PositionX--;
            return originalPosition;
        }
    }
}