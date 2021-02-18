namespace Chess
{
    public class MoveRight : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            originalPosition.PositionX = originalPosition.PositionX++;
            return originalPosition;
        }
    }
}