namespace Chess
{
    public class MoveRightBackwardKnight : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            originalPosition.PositionY = originalPosition.PositionY - 1;
            originalPosition.PositionX = originalPosition.PositionX + 2;
            return originalPosition;
        }
    }
}