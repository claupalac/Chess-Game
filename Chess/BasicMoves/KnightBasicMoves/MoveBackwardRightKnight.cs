namespace Chess
{
    public class MoveBackwardRightKnight : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            originalPosition.PositionY = originalPosition.PositionY - 2;
            originalPosition.PositionX = originalPosition.PositionX + 1;
            return originalPosition;
        }
    }
}