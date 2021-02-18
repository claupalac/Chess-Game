namespace Chess
{
    public class MoveLeft : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            originalPosition.PositionX = originalPosition.PositionX--;
            return originalPosition;
        }
    }
}